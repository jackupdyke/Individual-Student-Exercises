using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;
using USCitiesAndParks.DAO;
using USCitiesAndParks.Models;

namespace USCitiesAndParksTests
{
    [TestClass]
    public class StateSqlDaoTests
    {
        protected string ConnectionString { get; } = "Server=.\\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;";

        private TransactionScope transaction;

        private int initialStateCount = 0;

        [TestInitialize]
        public void Setup()
        {
            transaction = new TransactionScope();

            initialStateCount = GetRowCount("state");

            //confirm that city 170 (Las Vegas, NV) exists.
            CitySqlDao cityDao = new CitySqlDao(ConnectionString);
            City city = cityDao.GetCity(170);
            Assert.IsNotNull(city);

            // create a state for testing 
            // with Las Vegas, NV as the capital
            string sql = "INSERT INTO state (state_abbreviation, state_name, population, " +
                "area, capital, sales_tax) Values ('XY', 'Xylophone', 5, 6, 170, 1.0);";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
            }

            int finalStateCount = GetRowCount("state");
            Assert.AreEqual(initialStateCount + 1, finalStateCount);
        }

        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }

        [TestMethod]
        public void StateCreationTest()
        {
            //arrange
            StateSqlDao dao = new StateSqlDao(ConnectionString);

            //act
            State state = dao.GetState("XY");

            //assert
            Assert.IsNotNull(state);
            Assert.AreEqual("XY", state.StateAbbreviation);
        }

        [TestMethod]
        public void GetStateTest()
        {
            // arrange
            StateSqlDao stateDao = new StateSqlDao(ConnectionString);

            //act
            State state = stateDao.GetState("XY");

            //assert
            Assert.IsNotNull(state);
        }

        [TestMethod]
        public void GetStateByCapitalTest()
        {
            // arrange
            StateSqlDao stateDao = new StateSqlDao(ConnectionString);

            //act
            State state = stateDao.GetStateByCapital(170);

            //assert
            Assert.IsNotNull(state);
        }

        [TestMethod]
        public void GetStates()
        {
            // arrange
            StateSqlDao stateDao = new StateSqlDao(ConnectionString);

            //act
            IList<State> states = stateDao.GetStates();

            //assert
            Assert.AreEqual(initialStateCount + 1, states.Count);
        }

        protected int GetRowCount(string table)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table}", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Transactions;
using USCitiesAndParks.DAO;
using USCitiesAndParks.Models;

namespace USCitiesAndParksTests
{
    [TestClass]
    public class CitySqlDaoTests
    {
        protected string ConnectionString { get; } = "Server=.\\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;";

        private TransactionScope transaction;

        [TestInitialize]
        public void Setup()
        {
            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }

        [TestMethod]
        public void CityCreationTest()
        {
            City city = new City();
            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void GetCityTest()
        {
            //arrange
            CitySqlDao cityDao = new CitySqlDao(ConnectionString);

            //Act

            City city = cityDao.GetCity(170);

            //Assert

            Assert.IsNotNull(city);

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

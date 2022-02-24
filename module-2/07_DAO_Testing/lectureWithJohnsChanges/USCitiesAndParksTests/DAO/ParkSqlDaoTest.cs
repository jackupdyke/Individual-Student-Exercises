using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Transactions;
using USCitiesAndParks.Models;

namespace USCitiesAndParksTests
{
    [TestClass]
    public class ParkSqlDaoTest
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
        public void ParkCreationTest()
        {
            Park park = new Park();
            Assert.IsNotNull(park);
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


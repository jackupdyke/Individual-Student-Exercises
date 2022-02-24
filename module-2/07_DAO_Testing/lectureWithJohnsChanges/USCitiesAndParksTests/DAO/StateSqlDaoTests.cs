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
    public class StateSqlDaoTests :CitySqlDaoTests
    {


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


    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Transactions;
using USCitiesAndParks.DAO;
using USCitiesAndParks.Models;

namespace USCitiesAndParksTests 
{
    [TestClass]
    public class CitySqlDaoTests : CitiesAndParksTests
    {
      
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

            //act
            City city = cityDao.GetCity(170);

            //assert
            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void CreateCityTest()
        { 
            //arrange
            CitySqlDao cityDao = new CitySqlDao(ConnectionString);
            City city = new City();
            city.CityName = "Concrete";
            city.Population = 3;
            city.StateAbbreviation = "XY";
            city.Area = 2;

            //acct
            City newCity = cityDao.CreateCity(city);

            //assert
            Assert.IsNotNull(newCity);
        }
    }
}

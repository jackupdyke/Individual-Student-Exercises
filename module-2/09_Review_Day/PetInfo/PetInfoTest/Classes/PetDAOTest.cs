using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetInfo;
using PetInfo.Classes.DAO;
using System.Collections.Generic;

namespace PetInfoTest
{
    [TestClass]
    public class PetDAOTest
    {
        PetDAO petDAO;
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=PetInfo;Integrated Security=True";


        [TestInitialize]
        public void Setup()
        {
            // Arrange
            petDAO = new PetDAO(connectionString);
        }

        [TestCleanup]
        public void Cleanup()
        {
            //no cleanup 
        }

        [TestMethod]
        public void PetDAOConstructor()
        {
            Assert.IsNotNull(petDAO);
        }

        [TestMethod]
        [DataRow("Dog 1", "dog", "All American")]
        public void PetDAOAddPet(string name, string type, string breed)
        {
            //Act
            petDAO.AddPet(name, type, breed);
            List<Pet> pets = petDAO.GetPets();

            //Assert
            Assert.AreEqual(name, pets[0].Name);
        }
    }
}

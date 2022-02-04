using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetInfo;

namespace PetInfoTest
{
    [TestClass]
    public class PetWorksTest
    {
        PetWorks petWorks;

        [TestInitialize]
        public void Setup()
        {
            petWorks = new PetWorks();
        }

        [TestCleanup]
        public void Cleanup()
        {
            //no cleanup needed - you could leave this method out
        }

        [TestMethod]
        public void PetWorksConstructor()
        {
            Assert.IsNotNull(petWorks);
        }

        [TestMethod]
        [DataRow(1001, "Dog 1", "dog", "All American")]
        [DataRow(0, "Dog 1", "dog", "All American")]
        [DataRow(-1, "Dog 1", "dog", "All American")]
        public void PetWorksAddPet(int id, string name, string type, string breed)
        {
            //Act
            //pets.AddPet(id, name, type, breed);
            //Pet[] pets = pets.GetPets();

            ////Assert
            //Assert.AreEqual(id, pets[1].Id);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetInfo;

namespace PetInfoTest
{
    [TestClass]
    public class PetWorksTest
    {
        private PetWorks petWorks;

        [TestInitialize]
        public void Setup()
        {
            // Arrange
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
            petWorks.AddAPet(id, name, type, breed);
            Pet[] pets = petWorks.GetPets();

            ////Assert
            Assert.AreEqual(id, pets[0].Id);
            Assert.AreEqual(name, pets[0].Name);
        }

        [TestMethod]
        public void PetWorksDeletePet()
        {
            petWorks.AddAPet(7, "Lucky", "parrot", "Congo African Grey");

            Pet[] result = petWorks.GetPets();

            int count = result.Length;

            Assert.AreEqual(1, count);

            petWorks.DeleteAPet(7);

            result = petWorks.GetPets();

            count = result.Length;

            Assert.AreEqual(0, count);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void HavePartyTest()
        {
            //haveParty(30, false) → false
            //haveParty(50, false) → true
            //haveParty(70, true) → true

            //Arrange
            CigarParty testObject = new CigarParty();

            //Act
            bool result = testObject.HaveParty(50, false);

            //Assert

            Assert.IsTrue(result);
        }
    }
}

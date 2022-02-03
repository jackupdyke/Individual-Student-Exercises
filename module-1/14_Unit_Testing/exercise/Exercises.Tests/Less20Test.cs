using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]
        public void IsLessThanMultipleOf20Test()
        {
            //less20(18) → true
            //less20(19) → true
            //less20(20) → false

            //Arrange
            Less20 testObject = new Less20();

            //Act
            bool result = testObject.IsLessThanMultipleOf20(18);

            //Assert

            Assert.IsTrue(result);

        }
    }
}

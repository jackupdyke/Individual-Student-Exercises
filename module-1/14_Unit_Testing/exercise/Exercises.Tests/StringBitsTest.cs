using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void GetBitsTest()
        {
            //GetBits("Hello") → "Hlo"
            //GetBits("Hi") → "H"
            //GetBits("Heeololeo") → "Hello"

            //Arrange
            StringBits testObject = new StringBits();

            //Act
            string result = testObject.GetBits("Hello");

            //Assert

            Assert.AreEqual("Hlo", result);

        }
    }
}

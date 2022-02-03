using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void GetPartialStringTest()
        {
            //GetPartialString("Hello", "There") → "ellohere"
            //GetPartialString("java", "code") → "avaode"
            //GetPartialString("shotl", "java") → "hotlava"

            //Arrange

            NonStart testObject = new NonStart();
            //Act
            string result = testObject.GetPartialString("Hello", "There");

            //Assert

            Assert.AreEqual("ellohere", result);
        }
    }
}

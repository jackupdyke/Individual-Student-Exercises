using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void GenerateStringTest()
        {
            //frontTimes("Chocolate", 2) → "ChoCho"
            //frontTimes("Chocolate", 3) → "ChoChoCho"
            //frontTimes("Abc", 3) → "AbcAbcAbc"
           
            //Arrange
            FrontTimes testObject = new FrontTimes();

            //Act
            string result = testObject.GenerateString("Chocolate", 2);


            //Assert

            Assert.AreEqual("ChoCho", result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void GetLuckyTest()
        {
             //GetLucky([0, 2, 4]) → true
             //GetLucky([1, 2, 3]) → false
             //GetLucky([1, 2, 4]) → false

            //Arrange
            Lucky13 testObject = new Lucky13();

            //Act
            int[] input = new int[3] { 0, 2, 4 };

            bool result = testObject.GetLucky(input);

            //Assert

            Assert.IsTrue(result);

        }
    }
}

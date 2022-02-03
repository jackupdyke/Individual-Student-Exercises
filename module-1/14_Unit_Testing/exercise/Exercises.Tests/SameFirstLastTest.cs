using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void IsItTheSameTest()
        {
            //IsItTheSame([1, 2, 3]) → false
            //IsItTheSame([1, 2, 3, 1]) → true
            //IsItTheSame([1, 2, 1]) → true
            //Arrange

            SameFirstLast testObject = new SameFirstLast();

            //Act

            int[] input = new int[4] { 1, 2, 3, 1 };

            bool result = testObject.IsItTheSame(input);

            //Assert
            Assert.IsTrue(result);
        }
    }
}

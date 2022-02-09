using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void MakeArrayTest()
        {
            //MakeArray([1, 2, 3]) → [3, 3, 3]
            //MakeArray([11, 5, 9]) → [11, 11, 11]
            //MakeArray([2, 11, 3]) → [3, 3, 3]

            //Arrange
            MaxEnd3 testObject = new MaxEnd3();

            //Act

            int[] input = new int[3] { 1, 2, 3 };
            int[] output = new int[3] { 3, 3, 3 };
            int[] result = testObject.MakeArray(input);

            //Assert

            CollectionAssert.AreEqual(result, output);
            
        }
    }
}

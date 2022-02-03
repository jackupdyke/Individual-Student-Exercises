using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void GetATableTest()
        {


            //dateFashion(5, 10) → 2
            //dateFashion(5, 2) → 0
            //dateFashion(5, 5) → 1

            //Arrange
            DateFashion testObject = new DateFashion();

            //Act
            int result = testObject.GetATable(5, 5);

            //Assert

            Assert.AreEqual(1, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        [TestMethod()]
        public void MaxEnd3Test()
        {
            //Arrange
            LoopsAndArrayExercises testObject = new LoopsAndArrayExercises();

            //Act
            int[] result = testObject.MaxEnd3(new int[] { 1, 5, 9 });
            //Assert
            CollectionAssert.AreEqual(new int[] { 9, 9, 9 }, result);

        }
          
        
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object


    }
}

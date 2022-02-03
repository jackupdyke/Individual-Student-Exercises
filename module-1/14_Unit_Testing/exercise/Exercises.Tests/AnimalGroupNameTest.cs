using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void GetHerdTest()
        {

            //Rhino->Crash
            //Giraffe->Tower
            //Elephant->Herd
            //Lion->Pride
            //Crow->Murder
            //Pigeon->Kit
            //Flamingo->Pat
            //Deer->Herd
            //Dog->Pack
            //Crocodile->Float
            //GetHerd("giraffe") → "Tower"
            //GetHerd("")-> "unknown"
            //GetHerd("walrus")-> "unknown"
            //GetHerd("Rhino")-> "Crash"
            //GetHerd("rhino")-> "Crash"
            //GetHerd("elephants")-> "unknown"


            //Arrange

            AnimalGroupName testObject = new AnimalGroupName();

            //Act

            string result = testObject.GetHerd("GIRAFFE");

            //Assert

            Assert.AreEqual("Tower", result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            //GetCount(["ba", "ba", "black", "sheep"]) → { "ba" : 2, "black": 1, "sheep": 1 }
            //GetCount(["a", "b", "a", "c", "b"]) → { "a": 2, "b": 2, "c": 1}
            //GetCount([]) → { }
            //GetCount(["c", "b", "a"]) → { "c": 1, "b": 1, "a": 1}

            //Arrange

            WordCount testObject = new WordCount();

            //Act

            string[] input = new string[3] { "c", "b", "a" };

            Dictionary<string, int> answer = new Dictionary<string, int>();
            answer.Add("c", 1);
            answer.Add("b", 1);
            answer.Add("a", 1);
            Dictionary<string, int> result = testObject.GetCount(input);


            //Assert

            CollectionAssert.AreEqual(result, answer);
            


        }
    }
}

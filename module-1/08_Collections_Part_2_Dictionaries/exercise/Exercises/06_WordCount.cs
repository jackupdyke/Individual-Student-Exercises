using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string item in words)
            {

                if (result.ContainsKey(item))
                {
                    
                    result[item] += 1;
                }



                else
                {
                    result[item] = 1;
                }
            }

            return result;
        }
    }
}

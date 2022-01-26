namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Count the number of "xx" in the given string. Overlapping is allowed, so "xxx" contains 2 "xx".
        CountXX("abcxx") → 1
        CountXX("xxx") → 2
        CountXX("xxxx") → 3
        */
        public int CountXX(string str)
        {
            int count = 0;
            int length = str.Length; 
            for(int i = 0; i < length - 1; i++)
            {
                if(str.Substring(i,1) == "x" && str.Substring(i + 1, 1) == "x")
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}

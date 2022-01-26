namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and a non-negative int n, return a larger string that is n copies of the original string.
        StringTimes("Hi", 2) → "HiHi"
        StringTimes("Hi", 3) → "HiHiHi"
        StringTimes("Hi", 1) → "Hi"
        */
        public string StringTimes(string str, int n)
        {

            
            if (n > 0)
            {

                string result = str;
                for (int i = 1; i <= n - 1; i++)
                {
                    result = result + str;
                }

                return result;
            }
            else
            {
                return "";
            }
            
        }
    }
}

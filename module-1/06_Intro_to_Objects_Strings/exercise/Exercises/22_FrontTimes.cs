﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
        whatever is there if the string is less than length 3. Return n copies of the front;
        FrontTimes("Chocolate", 2) → "ChoCho"
        FrontTimes("Chocolate", 3) → "ChoChoCho"
        FrontTimes("Abc", 3) → "AbcAbcAbc"
        */
        public string FrontTimes(string str, int n)
        {

            int length = str.Length;

            if (length >= 3)
            {
                string result = "";
                for (int i = 0; i < n; i++)
                {
                    result += str.Substring(0, 3);
                }
                return result;
            }
            else
            {
                string result = "";
                for (int i = 0; i < n; i++)
                {
                   result += str.Substring(0, length);
                }
                return result;
            }

            

        }    
            

            

        

    }
}

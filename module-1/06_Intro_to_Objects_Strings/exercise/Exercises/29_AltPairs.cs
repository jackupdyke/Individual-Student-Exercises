namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {
            string result = "";
            int length = str.Length;

            for (int i = 0; i < length; i += 4)
            {
                result += str.Substring(i, 1);

                if(i + 1 < length)
                {
                    result += str.Substring(i + 1, 1);
                }

                    
               
                


            }
            return result;
        }   
    }
}

namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {

            string result = "";
            string beginning = "x";
            string ending = "x";
            int length = str.Length;

            for(int i = 0; i < length; i++)
            {
                if(str[i] != 'x')
                {
                    result += str[i];
                }
                
            }
            if (length > 1)
            {


                if (str[0] == 'x' && str[length - 1] == 'x')
                {
                    return beginning + result + ending;
                }
                else if (str[0] == 'x')
                {
                    return beginning + result;
                }
                else if (str[length - 1] == 'x')
                {
                    return result + ending;
                }
                else
                {
                    return result;
                }
            }
            return str;
         
        }
    }
}

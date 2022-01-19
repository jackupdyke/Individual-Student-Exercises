namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Given 2 int values, return the larger value that is in the range 10..20 inclusive,
         or return 0 if neither is in that range.
         Max1020(11, 19) → 19
         Max1020(19, 11) → 19
         Max1020(11, 9) → 11
         */
        public int Max1020(int a, int b)
        {
            if ((a < 10 || a > 20) && (b < 10 || b > 20))
            {
                return 0;
            }
            else if ((10 <= a && a <= 20) && (b < 10 || b > 20))
            {
                return a;
            }
            else if ((a < 10 || a > 20) && (10 <= b && b <=20))
            {
                return b;
            }
            else if ((10 <= a && a <= 20) && (10 <= b && b <= 20) && a >=b)
            {
                return a;
            }
            else 
            {
                return b;
            }
            
        }
    }
}

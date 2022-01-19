namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Return true if the given non-negative number is 1 or 2 more than a multiple of 20.
         (Hint: Think "mod".)
         More20(20) → false
         More20(21) → true
         More20(22) → true
         */
        public bool More20(int n)
        {
            if (n % 20 >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}

﻿namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
	     The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on
	     vacation. We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.
	     SleepIn(false, false) → true
	     SleepIn(true, false) → false
	     SleepIn(false, true) → true
	     */
        public bool SleepIn(bool weekday, bool vacation)
        {
            if (weekday == true && vacation == false)
            {
                return false;

            }
            else if (weekday == false && vacation == true)
            {
                return true;
            }
            else
            {
                return true;
            }
            
        }
    }
}

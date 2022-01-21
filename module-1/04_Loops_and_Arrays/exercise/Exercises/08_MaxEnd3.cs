namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements
         in the array, and set all the other elements to be that value. Return the changed array.
         MaxEnd3([1, 2, 3]) → [3, 3, 3]
         MaxEnd3([11, 5, 9]) → [11, 11, 11]
         MaxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            if(nums[0] > nums[2])
            {
                int[] result = new int[3];
                result[0] = nums[0];
                result[1] = nums[0];
                result[2] = nums[0];

                return result;

                }
            else if(nums[2] > nums[0])
            {
                int[] result2 = new int[3];
                result2[0] = nums[2];
                result2[1] = nums[2];
                result2[2] = nums[2];

                return result2;
            }
            else
            {
                return nums;
            }

            }
            
        }
    }


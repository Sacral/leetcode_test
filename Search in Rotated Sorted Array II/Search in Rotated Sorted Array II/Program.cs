using System;
using System.Collections.Generic;

namespace Search_in_Rotated_Sorted_Array_II
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = {2, 5, 6, 0, 0, 1, 2};


            Console.WriteLine(Search(nums,0));
        }

        public static bool Search(int[] nums, int target)
        {

            List<int> list_num = new List<int>();


            for (int i = 0; i < nums.Length; i++)
            {
                list_num.Add(nums[i]);

            }

            int num_index = list_num.IndexOf(target);

           /* if (num_index != -1)
            {
                return true;
            }*/

            //classify = (input >= 0) ? "nonnegative" : "negative";



            return (num_index==-1)?false:true;
        }

    }
}

using System;
using System.Collections.Generic;


namespace Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] nums = {4, 5, 6, 7, 0, 1, 2};



            Console.WriteLine(Search(nums,3));
        }

        public static int Search(int[] nums, int target)
        {

            List<int> list_num = new List<int>();


            for(int i = 0; i < nums.Length; i++)
            {
                list_num.Add(nums[i]);

            }

            int num_index = list_num.IndexOf(target);

            return num_index;
        }


    }
}

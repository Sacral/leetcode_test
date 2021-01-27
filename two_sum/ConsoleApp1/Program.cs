using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 11, 15,2, 7  };
            int target = 9;

            //TwoSum two = new TwoSum();

            Console.WriteLine(TwoSum(nums,target));

        }

        public static int[] TwoSum(int[] nums, int target)
        {

            int[] ary = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {


                    for (int j = i + 1; j < nums.Length; j++)
                    {

                            if (nums[i] + nums[j] == target)
                            {
                                Console.WriteLine("i= " + i + " j= " + j);

                                ary[0] = i;
                                ary[1] = j;

                            }
                     }


            }

            return ary;
        }



    }
}

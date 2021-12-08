using System;
using System.Collections.Generic;

namespace Next_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 3, 2, 1 }; 

            Console.WriteLine(NextPermutation(nums));


        }

        public static int []   NextPermutation(int[] nums)
        {
            List<int> num = new List<int>();
            List<int> compare = new List<int>();

            int o_num = 0;
            int now_num = 0;
            string now = "";
            int tmp = 0;
            int num_length = nums.Length;
            int index = 0;

            if (num_length == 0 || num_length == 1)
            {
                return nums;
            }

            //先找到不合升序的index

            for(int i = 1; i < num_length; i++)
            {
                if (nums[num_length - 1] >= nums[i])
                {
                    continue;
                }

                else
                {
                    index = i;
                }
            }





            for(int i = 0; i < nums.Length; i++)
            {

                num.Add(nums[i]);
                o_num = o_num + nums[i] * Convert.ToInt32( Math.Pow(10, nums.Length - 1 - i)); //原來的數字

            }

            tmp = num[nums.Length - 1];

            num[nums.Length - 1] = num[nums.Length - 2];

            num[nums.Length - 2] = tmp;

            for(int i=0;i< nums.Length; i++)
            {
                now_num = now_num + num[i] * Convert.ToInt32(Math.Pow(10, nums.Length-1-i)); // 新數字
            }

            if (now_num > o_num)
            {
                int[] re = num.ToArray();

                Console.WriteLine(now_num);

                return re;
            }


            return nums;
        }

    }
}

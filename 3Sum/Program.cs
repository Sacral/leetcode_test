using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { -1, 0, 1, 2, -1, -4 };
            //[0,1,1]
            //int[] nums = { 0,1,1 };
            //[3,0,-2,-1,1,2]
            //int[] nums = { 3, 0, -2, -1, 1, 2 };
            //int[] nums = {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0};
            int[] nums = {-13, 5, 13, 12, -2, -11, -1, 12, -3, 0, -3, -7, -7, -5, -3, -15, -2, 14, 14, 13, 6, -11, -11, 5, -15, -14, 5, -5, -2, 0, 3, -8, -10, -7, 11, -5, -10, -5, -7, -6, 2, 5, 3, 2, 7, 7, 3, -10, -2, 2, -12, -11, -1, 14, 10, -9, -15, -8, -7, -9, 7, 3, -2, 5, 11, -13, -15, 8, -3, -7, -12, 7, 5, -2, -6, -3, -10, 4, 2, -5, 14, -3, -1, -10, -3, -14, -4, -3, -7, -4, 3, 8, 14, 9, -2, 10, 11, -10, -4, -15, -9, -1, -1, 3, 4, 1, 8, 1};

        Console.WriteLine(ThreeSum(nums));
        }


        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<int> new_list = new List<int>();
            List<int> tmp_list = new List<int>();

            IList<IList<int>> result_list = new List<IList<int>>();
            IList<IList<int>> result_list2 = new List<IList<int>>();


            if (nums.Length>=3)
            {
                int first = 0;
                int third = nums.Length - 1;
                int second = first + 1;
                

                Array.Sort(nums);

                Console.WriteLine("Array.Sort == " + string.Join(",", nums));


                for (int i = 0; i < nums.Length-2; i++)
                {
                    third = nums.Length - 1;
                    int j = i + 1;

                    /*for (int j = 1; j < nums.Length; j++)
                    {*/
                    while ( j < third ) { 

                        /*for(int k=third; k>=0;k--)
                            {*/

                                int tmp_sum = nums[i] + nums[j] + nums[third];

                                //if (tmp_sum == 0 && j != third && i != j && i != third)
                                if (tmp_sum == 0 && j != third && i != third && i != j)
                                {

                                    new_list = new List<int>
                                {
                                    nums[i], nums[j], nums[third]
                                };

                                    new_list.Sort();
                                    result_list.Add(new_list);
                                    j++;
                                    third--;
                            /* Console.WriteLine("index i == " + string.Join(",", i));
                            Console.WriteLine("index j == " + string.Join(",", j_index));
                            Console.WriteLine("index t == " + string.Join(",", third));
                            Console.WriteLine("new_list == " + string.Join(",", new_list));*/

                        }

                                else if (tmp_sum > 0)
                                {

                                    third--;
                                    continue;

                                }

                                else if (tmp_sum < 0)
                                {
                                    //second++;
                                    j++;
                                    continue;
                                }

                                

                            //}

                    }
                }

                foreach (var i in result_list)
                {

                    Console.WriteLine("result_list == " + string.Join(",", i));

                }



                /*foreach (var item in result_list)
                {
                    var check = false;
                    foreach (var result in result_list2)
                    {
                        //if (item.Except(result).Any() == false)
                        if (result.Except(item).Any() == false)
                        {
                            //代表已經有
                            check = true;
                        }
                    }

                    if (check == false)
                    {
                        result_list2.Add(item);
                    }
                }

                foreach (var i in result_list2)
                {

                    Console.WriteLine("result_list2 == " + string.Join(",", i));
                }*/
               
            }

            return result_list2;

        }
    
    }
}

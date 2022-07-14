using System;
using System.Collections.Generic;

namespace CamelcaseMatching
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] queries = new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" };
            string pattern = "FB";

            Console.WriteLine(Solution.CamelMatch(queries, pattern));
        }

    }

    static public class Solution
    {
        public static IList<bool> CamelMatch(string[] queries, string pattern)
        {

            //pattern有大寫的部份
            List<char> upcase = new List<char>();

            for(int i = 0; i < pattern.Length; i++)
            {
                //upcase[i] = pattern[i];

                if (Char.IsUpper(pattern[i]))
                {
                    upcase[i] = pattern[i]; 
                }

            }


            //queries有大寫的部份
            List<string> temp = new List<string>();//放ary裡的字串的大寫
            List<string> temp2 = new List<string>();//放temp

            for (int i = 0; i < queries.Length; i++)
            {
                for(int j = 0; j < queries[i].Length; j++)
                {

                }

            }




            //找出包含UPCASE裡的ARY
            //把WHERE字串接起來

            
            //foreach(char i in upcase)
            //{
            //    if ()
            //    {

            //    }
            //}



            bool[] output = new bool[] { false };
            return output;
        }

        public static char Upperchk(char pattern)
        {

            return pattern;

        }
    }
}

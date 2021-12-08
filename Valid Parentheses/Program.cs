using System;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "";

            Console.WriteLine(IsValid(s));
        }


        public static bool IsValid(string s)
        {

            if ((s.Length % 2) != 0)
            {
                //奇數
                return false;
            }

            //取得中間的index
            int pre_idx = (s.Length/2)-1;
            int next_idx = s.Length/2 ;




            return true;
        }
    }
}

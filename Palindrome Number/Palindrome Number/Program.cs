using System;
using System.Collections.Generic;


namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            IsPalindrome(12222221);

            Console.WriteLine(IsPalindrome(122278921));
        }


        public static bool IsPalindrome(int x)
        {

            string s = x.ToString();

            int length = s.Length;
            double center = length/2;
            bool fin=false;


            List<string> ls = new List<string>();

            for (int i = 0; i< length; i++)
            {
                ls.Add(s.Substring(i, 1));
            }

            //左右比數到cneter就好了
            for (int i =0;i<=center;i++)
            {

                Console.WriteLine("ls[i] = " + ls[i].ToString() + "   ls[length-1-i]"+ ls[length - 1 - i].ToString()+ "   i  ="+i+"    center  ="+center);

                if (Comparer(ls[i], ls[length - 1 - i]))
                {
                    fin = true;
                }

                else
                {
                    return false;
                }

            }

            return fin;
        }


        public static bool Comparer(string a,string b)
        {
            if (a == b)
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

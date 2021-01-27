using System;
using System.Collections.Generic;


namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse(32768);
            //Reverse(1534236469);
            Reverse(-2147483648);
        }


        public static int Reverse(int x)
        {

            List<long> num_x = new List<long>();
            long y;
            long sum = 0;
            int length = 0;

            if (Compare(x) == 0)
            {
                sum = 0;
            }

            else
            {
                string num;
                y = x;
                num = y.ToString();
                
                if (x < 0)
                {

                    length = num.Length - 1;
                }

                else
                {
                    length = num.Length;
                }

               
                long list_num2;

                int p = 0;

                for (int i = 0; i < length; i++)
                {

                    list_num2 = y % 10;

                    num_x.Add(list_num2);

                    y = y / 10;
                    p = length - 1 - i;

                    sum = sum + num_x[i] * (long)Math.Pow(10, p);

                }

                foreach (int result in num_x)
                {
                    Console.WriteLine(result);

                }

                if (Compare(sum) == 0)
                {
                    sum = 0;
                }

            }

            Console.WriteLine("sum="+sum);
            Console.WriteLine((Int64)Math.Pow(-2, 31));
            Console.WriteLine((Int64)Math.Pow(2, 31-1));

            return (int)sum;

        }

        public static long Compare(long number)
        {

            if (number > (long)Math.Pow(2, 31) - 1)
            {
                number = 0;
            }

            else if (number < (long)Math.Pow(-2, 31))
            {
                number = 0;
            }
            else
            {
                number = number;
            }
           

            return number;
        }

    }
}

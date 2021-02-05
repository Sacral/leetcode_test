using System;

namespace Divide_Two_Integers
{

    static public class GlobalPara
    {
        static public int quotient = 0;
    }



    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine(Divide(7,-3));


        }


        public static int Divide(int dividend, int divisor)
        {


            int result = 0;
            int a = 0;
            int b = 0;

            if (divisor < 0)
            {
                a = Math.Abs(divisor + divisor);
            }
            if (dividend < 0)
            {
                b = dividend;
            }


            if (Math.Abs(dividend) >= Math.Abs(divisor))
            {

                result = Cal(dividend, divisor);

                GlobalPara.quotient = GlobalPara.quotient + 1;

                Divide(result, divisor);

            }

            else
            {

               // return result;
            }


            if ((a != 0&&b==0) || (b!=0&&a==0))
            {
                int re = 0 - GlobalPara.quotient;

                return re;
            }




            return GlobalPara.quotient;
        }


        public static int  Cal(int div, int d)
        {
            int result = 0;

            int newd = Math.Abs(d);

            int newdiv = Math.Abs(div);


            if (newdiv >= newd)
            {
                result = newdiv - newd;
            }

            else
            {
                //return result;
            }




            Console.WriteLine("cal result == "+result);

            return result;
        }

    }

}

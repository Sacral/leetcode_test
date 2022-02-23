using System;
using System.Collections.Generic;


namespace Integer_to_Roman
{
    class Program
    {
        static void Main(string[] args)
        {

            //IntToRoman(3);

            Console.WriteLine(IntToRoman(1994));
        }


        public static string IntToRoman(int num)
        {
            string result1000 = "", result100 = "", result10 = "", result1 = "";

            result1000 = symbols(num, 1000);

            result100 = symbols(num % 1000, 100);

            result10 = symbols(num % 100, 10);

            result1 = symbols(num % 10, 1);
            

            return result1000+ result100+ result10+ result1;
        }

        /// <summary>
        /// 做重複的動作
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string symbols(int n , int m)
        {
            string  resultM = "", result = "",resultD="";
            int counM = 0;

            counM = n / m;

            switch (m)
            {
                case 1000:
                    resultM = "M";
                    break;
                case 100:
                    resultM = "C";
                    if (counM == 9)
                    {                    
                        resultD = "M";
                    }
                    else
                    {
                        resultD = "D";
                    }             
                    break;
                case 10:
                    resultM = "X";
                    
                    if (counM == 9)
                    {
                        resultD = "C";
                    }
                    else
                    {
                        resultD = "L";
                    }
                    break;
                case 1:
                    resultM = "I";
                    
                    if (counM == 9)
                    {
                        resultD = "X";                    
                    }
                    else
                    {
                        resultD = "V";
                    }
                    break;
            }           

            if ( counM >= 1 && counM < 4)
            {
                result = resultM;

                for (int i = 1; i < counM; i++)
                {
                    result = result + resultM;
                }
                
            }
            else if(counM > 5 && counM < 9)
            {
                result = resultD;

                counM = counM - 5;

                for (int i = 0; i < counM; i++)
                {
                    result = result + resultM;
                }

            }
            else if (counM == 5)
            {
                result = resultD;
            }
            else if(counM == 4 || counM == 9)
            {
                result = resultM + resultD ;
            }


            return result;

        }


    }
}

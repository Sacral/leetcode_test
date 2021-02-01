using System;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "ab", "a"};
           // string[] array = {"a"};

            //string[] array = { "flower", "flow", "flight" };

           // string[] array = { "flower", "flower", "flower", "flower" };

            LongestCommonPrefix(array);

            Console.WriteLine("final  return_s =   " + LongestCommonPrefix(array));

        }


        public static string LongestCommonPrefix(string[] strs)
        {
            string return_s = "";


            if (strs.Length <= 1)
            {

                if (strs.Length == 0)
                {
                    return "";
                }
                else
                {
                    return strs[0];
                }
            }
            else
            {
                for (int i = 0; i< strs[0].Length; i++)
                {

                    return_s = strs[0][i].ToString();


                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (strs[j].Length == i || strs[j][i].ToString() != return_s)//停止迴圈的條件
                        {

                            Console.WriteLine(strs[0].Substring(0, i));

                              return strs[0].Substring(0, i);

                        }

                    }
                }

                return strs[0];
            }

        }

    }
}

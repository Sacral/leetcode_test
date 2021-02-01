using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Common_Prefix
{
    class Class1
    {
        static void Main(string[] args)
        {
            string[] array = { "ab", "a" };
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
                        //return_s = "";
                        return "";
                    }
                    else
                    {
                        //return_s = strs[0];
                        return strs[0];
                    }

                }
                else
                {
                    return_s = compare(strs[0], strs[1]);

                    for (int i = 1; i + 1 < strs.Length; i++)
                    {
                        return_s = compare(return_s, strs[i + 1]);
                    }

                    return return_s;
                }
            }


            public static string compare(string str_a, string str_b)
            {
                string re_s = "";
                int length;

                if (str_a.Length < str_b.Length)
                {
                    length = str_a.Length;
                }
                else
                {
                    length = str_b.Length;
                }


                for (int j = 0; j < length; j++)
                {

                    if (str_a.Substring(j, 1) == str_b.Substring(j, 1))
                    {
                        re_s += str_a.Substring(j, 1);
                    }
                    else
                    {
                        break;
                    }

                }


                return re_s;
            }
        }
    

}

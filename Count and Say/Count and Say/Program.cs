using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_and_Say
{
    class Program
    {
        static void Main(string[] args)
        {

            //CountAndSay(4);
            //CountAndSay(5);
            Console.WriteLine("start++++" + CountAndSay(6));

        }

        public static string CountAndSay(int n)
        {
            List<P2> p2 = new List<P2>();

            string start = "1";

            char re_char = '0';

            string result = "";

            int coun=1;

            if (n <= 1)
            {
                return start;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    Console.WriteLine("*************************start " + start);

                    for (int j = 0; j < start.Length; j++)
                    {
                        re_char = start[j];
                        /*char[] source = start.ToCharArray(0, start.Length);

                        var machQuery = from word in source
                                        where word == re_char
                                        select word;
                        
                        Console.WriteLine("-------------------------re_char  =  " + re_char + "  source  =   " + source.ToString());
                        */
                        /*bool ex = p2.Exists(x => x.name == re_char.ToString());

                        if (ex == false)
                        {
                            p2.Add(new P2() { name = re_char.ToString(), count = machQuery.Count() });


                        }*/


                        Console.WriteLine("rechar  =  " + re_char);

                        //如果有前面的
                        if (j - 1 >= 0 )
                        {
                            //如果跟前面的一樣 //在最新的id相加
                            if (re_char == start[j - 1])
                            {
                                coun = coun+1;
                                Console.WriteLine("coun ////////////// " + coun);

                                int indd = p2.Count - 1;

                                p2[indd].count_ = coun;


                                //如果到底了
                                if (j == start.Length - 1)
                                {

                                    //int ind = p2.LastIndexOf(new P2() { name = re_char.ToString() });

                                    int ind = p2.Count - 1;

                                    //p2.Insert(ind ,new P2() { name = re_char.ToString(), count_ = coun });
                                    p2[ind].count_ = coun;
                                    
                                }

                            }

                            //如果跟前面不一樣 //後面還有數字
                            else if(re_char != start[j - 1] && j+1!=start.Length)
                            {
                                coun = 1;
                                //新增現在的資料
                                p2.Add(new P2() { name = re_char.ToString(), count_ = coun });

                                //coun = 1;
                                //p2.Add(new P2() { name = re_char.ToString(), count = coun });

                                //如果到底了
                                if (j == start.Length - 1)
                                {
                                    coun = 1;
                                    p2.Add(new P2() { name = re_char.ToString(), count_ = coun });
                                }

                            }
                            //如果到底
                            else if (j == start.Length - 1)
                            {
                                coun = 1;
                                p2.Add(new P2() { name = re_char.ToString(), count_ = coun });
                            }


                        }
                        //如果沒有前面的
                        //先存進去
                        else if (j==0)
                        {
                            coun = 1;
                            p2.Add(new P2() { name = re_char.ToString(), count_ = coun });
                        }

                    }
                    /*
                    if (coun != 0)
                    {
                        p2.Add(new P2() { name = re_char.ToString(), count = coun });
                        coun = 0;
                    }*/ 



                    //Console.WriteLine("p2count ==============" + p2.Count.ToString());

                    for (int k = 0; k < p2.Count; k++)
                    {


                        result =result + p2[k].count_.ToString() + p2[k].name.ToString();

                        Console.WriteLine("p2 =  " + p2[k].ToString());

                    }

                    p2.Clear();
                    start = result;
                    result = "";

                    Console.WriteLine("*************************result" + start);

                }

                return start;
            }

        }


    }

    public class P2
    {
        public string name { get; set; }
        public int count_ { get; set; }

        public override string ToString()
        {
            return "name: " + name + "   count: " + count_;
        }

    }


}

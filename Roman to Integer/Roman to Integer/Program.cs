using System;
using System.Collections.Generic;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {

            RomanToInt("LVIII");
            RomanToInt("III");
            RomanToInt("IX");
            RomanToInt("MCMXCIV");
            RomanToInt("MMCCCXCIX");
        }

        public static int RomanToInt(string s)
        {
            List<Roman_num> rom = new List<Roman_num>();

            rom.Add(new Roman_num() { roman_number = "I", number = 1 });
            rom.Add(new Roman_num() { roman_number = "V", number = 5 });
            rom.Add(new Roman_num() { roman_number = "X", number = 10 });
            rom.Add(new Roman_num() { roman_number = "L", number = 50 });
            rom.Add(new Roman_num() { roman_number = "C", number = 100 });
            rom.Add(new Roman_num() { roman_number = "D", number = 500 });
            rom.Add(new Roman_num() { roman_number = "M", number = 1000 });

            List<int> conver_num = new List<int>();

            string sub_string;
            int sum=0;

            for (int i = 0; i < s.Length; i++)
            {
                sub_string = s.Substring(i, 1);

                //Console.WriteLine("i="+ sub_string + "///////"+rom.Find(x => x.roman_number.Contains(sub_string)).number);

                conver_num.Add(rom.Find(x => x.roman_number.Contains(sub_string)).number);

                Console.WriteLine(conver_num[i].ToString());

            }

            int j = 1;
            int k = 2;
            int start = s.Length;
            string s_string="";
            string tmp="";
            int index=0;
            int tmp_index=0;

            sum = conver_num[start-1];

            foreach (var conver in conver_num)
            {

                if (start - k >= 0)
                {
                    tmp = s.Substring(start - k, 1);
                    tmp_index = rom.FindIndex(x => x.roman_number.StartsWith(tmp));
                    s_string = s.Substring(start - j, 1);
                    index = rom.FindIndex(x => x.roman_number.StartsWith(s_string));

                    if (s_string == "I")
                    {
                        sum = sum + conver_num[start - k];
                    }

                    else
                    {
                        if (index > tmp_index)
                        {
                            sum = sum - conver_num[start - k];
                        }

                        else if (tmp_index >= index)
                        {
                            sum = sum + conver_num[start - k];
                        }
                    }
                }

                Console.WriteLine(
                    "   sj  =  "+s_string + "index  =  "+index+
                    "   sk  =  "+tmp + "tmpindex   =   "+tmp_index+
                    "  sum  =  "+sum);

                j++;
                k++;
            }


            return sum;

        }

    }


    public class Roman_num
    {
        public string roman_number { get; set; }

        public int number { get; set; }

        public override string ToString()
        {
            return "roman_number: " + roman_number + "   number: " + number;
        }

    }

}

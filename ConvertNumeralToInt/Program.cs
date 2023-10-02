using System;
using System.Collections.Generic;

namespace ConvertNumeralToInt
{
    class Program
    {
        public int RomanToInt(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            var result = 0;
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);

            for (int i = 0; i < str.Length; i++)
            {
                var currVal = str[i];
                if (i > 0 && dic[str[i - 1]] < dic[currVal])
                {
                    result += dic[currVal];
                    var sub = 2 * dic[str[i - 1]];
                    result -= sub;

                }
                else
                {
                    result += dic[currVal];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the Roman numerals to convert: ");
            string numeral = Console.ReadLine().ToUpper();
            var result = new Program();
            Console.WriteLine();

            try
            {
                Console.Write(numeral + " = " + result.RomanToInt(numeral));
            }
            catch 
            {
                Console.WriteLine("You have entered an invalid number");
            }            
            Console.ReadKey();
        }
    }
}

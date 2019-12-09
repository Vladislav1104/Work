using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstring;
            do
            {
                Console.Write("Введите строку: ");
                inputstring = Convert.ToString(Console.ReadLine());

            } while (string.IsNullOrWhiteSpace(inputstring) == true);
            DataEditing(inputstring);
            Console.ReadLine();
        }
        static void DataEditing(String input)
        {
            string text = input;

            string pattern = @"([0?|\d]\d).([0]\d|[1][0-2]).(19\d{2}|20\d[0-7])";

            MatchCollection matches;
            Regex reg = new Regex(pattern);
            matches = reg.Matches(text);
            for (int i = 0; i < matches.Count; i++)
            {
                string updDate = matches[i].Value;
                updDate = DateTime.Parse(matches[i].Value).AddDays(+1).ToShortDateString();
                text = text.Replace(matches[i].Value, updDate);
            }
            Console.WriteLine(text);
        }
    }
}

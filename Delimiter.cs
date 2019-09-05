using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace challenge-calculator
{
    class Delimiter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the string to deliminate:");
            string input = Console.ReadLine();
            string formula = "";
            string math = "";
            List<string> list = new List<string>();
            int total = 0;
            int newval = 0;

            //check delimiter
            if (input.Contains(","))
                list = input.Split(",").ToList();
            else if (input.Length > 0)
                list.Add(input);

            //loop and try to parse each value else parse will return 0 to variable
            foreach(string str in list)
            {
                Int32.TryParse(str, out newval);
                total += newval;
                math += $"{newval}+";
            }

            //for version in case needed
            /*for (int i = 0; i < list.Count(); i++)
            {
                Int32.TryParse(list.ElementAt(i).ToString(), out newval);
                total += newval;
                math += $"{newval}+";
            }*/

            math.TrimEnd('+');
            math += $" = {total}";

            //to check results and also extra strech project stuff
            Console.WriteLine($"Formula: {formula}\nMath: {math}\nTotal: {total}\n");
        }
    }
}

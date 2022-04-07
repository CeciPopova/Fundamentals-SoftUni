using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            string pattern = @">>([A-Za-z]+)<<(\d+(.\d+)?)!(\d+)";
            List<string> results = new List<string>();

            while (input!="Purchase")
            {

                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string produktName = match.Groups[1].Value;
                    double produktPrice = double.Parse(match.Groups[2].Value);
                    double productQuantity = double.Parse(match.Groups[4].Value);
                    totalPrice += productQuantity * produktPrice;
                   results.Add(produktName);

                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (results.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, results));
            }
           
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}

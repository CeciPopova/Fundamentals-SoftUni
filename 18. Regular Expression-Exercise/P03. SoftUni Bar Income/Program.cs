using System;
using System.Text.RegularExpressions;

namespace P03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^|$%.]*?%([A-Z][a-z]+)%[^|$%.]*?<(\w+)>[^|$%.]*?\|([0-9]+)\|[^|$%.]*?(\d+\.?\d*)\$$";
           
            string input = Console.ReadLine();
            double total = 0;

            while (input!="end of shift")
            {
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string customerName = match.Groups[1].Value;
                    string product = match.Groups[2].Value; 
                    int count =int.Parse(match.Groups[3].Value); 
                    double price = double.Parse(match.Groups[4].Value);
                    double totalPrice = count * price;
                    total += totalPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }


                input = Console.ReadLine(); 
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}

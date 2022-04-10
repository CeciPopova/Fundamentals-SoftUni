using System;
using System.Text.RegularExpressions;

namespace E1._02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex pattern = new Regex(@"([#|\|])(?<product>[A-Za-z\s]+)(\1)(?<date>\d{2}/\d{2}/\d{2})(\1)(?<cal>\d+)(\1)");

            int totalCal = 0;
            MatchCollection matches = pattern.Matches(text);
            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    int calories = int.Parse(match.Groups["cal"].Value);
                    totalCal+=calories;
                }
            }
            int days = totalCal / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["product"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["cal"].Value}");
            }
        }
    }
}

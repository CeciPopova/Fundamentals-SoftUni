using System;
using System.Text.RegularExpressions;

namespace P06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s|^)(([a-z0-9]+(?:[_.-][a-z0-9]+)*)@((?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+))\b";
            
            MatchCollection validEmails = Regex.Matches(text, pattern);
            foreach (Match match in validEmails)
            {
                Console.WriteLine(match);
            }
        }
    }
}

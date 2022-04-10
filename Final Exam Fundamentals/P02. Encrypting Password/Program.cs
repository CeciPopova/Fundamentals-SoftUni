using System;
using System.Text.RegularExpressions;

namespace P02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"(.+)>(?:(\d{3})\|([a-z]{3})\|([A-Z]{3})\|(.{3}))<(\1)");
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string firstGroup = match.Groups[2].Value; 
                    string secondGroup = match.Groups[3].Value; 
                    string thirdGroup = match.Groups[4].Value;  
                    string fourthGroup = match.Groups[5].Value;
                    string password = firstGroup+secondGroup+thirdGroup+fourthGroup;
                    Console.WriteLine($"Password: {password}");    

                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}

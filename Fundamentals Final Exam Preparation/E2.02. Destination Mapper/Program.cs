using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace E2._02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  input = Console.ReadLine();
            Regex regex = new Regex(@"([=|\/])(?<destination>[A-Z][A-Za-z]{2,})(\1)");

            MatchCollection matches = regex.Matches(input); 
            int travelPoints = 0; 
            List<string> validDestinations = new List<string>();    
            foreach (Match match in matches)
                if (match.Success)
                {
                    string location = match.Groups["destination"].Value;
                    travelPoints+=location.Length;
                    validDestinations.Add(location);
                }
            Console.WriteLine($"Destinations: {string.Join(", ",validDestinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}

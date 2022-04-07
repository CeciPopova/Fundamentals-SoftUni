using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using System.Linq;

namespace P03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        { 
       
            Regex regex = new Regex(@"\b(?<day>\d{2})([-\.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            string dates = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(dates);
           

            foreach (Match match in matchCollection)
            {
                
                var day = match.Groups["day"].Value;
                
                var month = match.Groups["month"].Value;
               
                var year = match.Groups["year"].Value;
                
                
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }
            
        }
    }
}

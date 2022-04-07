using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex (@"\+359([-\s])2\1[0-9]{3}\1[0-9]{4}\b");
           
            string phones = Console.ReadLine();

            MatchCollection matchPhones = pattern.Matches(phones);
            
            List<string> phoneNumbers = new List<string>();

            foreach (Match match in matchPhones)
            {
                phoneNumbers.Add(match.Value);  
            }
            Console.WriteLine(string.Join(", ",phoneNumbers));
        }
    }
}
 
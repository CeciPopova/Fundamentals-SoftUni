using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ").ToArray();
            string command = Console.ReadLine();
            Dictionary<string, int> participantsDistance = new Dictionary<string, int>();

            foreach (var name in participants)
            {
                participantsDistance.Add(name, 0);
            }
            string patternLeters = @"[\W\d]";
            string patternDigits = @"[\WA-z]";

            while (command!= "end of race")
            {
                string name = Regex.Replace(command, patternLeters, "");
                string number = Regex.Replace(command, patternDigits, "");
                int totalKm = 0;    
           
               
                foreach (var item in number)
                {
                    int km = int.Parse(item.ToString());
                    totalKm += km;
                }


                if (participantsDistance.ContainsKey(name))
                {
                    participantsDistance[name] += totalKm;
                }

                command = Console.ReadLine();
            }
            int count = 0;
            foreach (var item in participantsDistance.OrderByDescending(x => x.Value))
            {
                count++;
                if (count==1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                if (count==2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                if (count==3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demonsNameslList = Console.ReadLine()
                 .Split(',', StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x.Trim())
                 .ToArray();

            Dictionary<string, Dictionary<double, double>> demons = new Dictionary<string, Dictionary<double, double>>();

            for (int i = 0; i < demonsNameslList.Length; i++)
            {
                string demon = demonsNameslList[i];

                double demonDemage = 0;

                Dictionary<double, double> demonsPowerDemage = new Dictionary<double, double>();
                demons.Add(demon, new Dictionary<double, double>());
                int totalDemonPower = 0;
                string patternName = @"[\-]?\d+[\.\d]*";
                MatchCollection match = Regex.Matches(demon, patternName);
                foreach (Match number in match)
                {
                    double demage = double.Parse(number.Value);
                    demonDemage += demage;
                }
                for (int j = 0; j < demon.Length; j++)
                {
                    char currChar = demon[j];
                    int power = (int)currChar;
                    if (char.IsLetter(currChar))
                    {
                        totalDemonPower += power;
                    }

                    if (currChar == '*')
                    {
                        demonDemage *= 2;
                    }
                    if (currChar == '/')
                    {
                        demonDemage /= 2;
                    }

                }
                demonsPowerDemage.Add(totalDemonPower, demonDemage);

                if (demons.ContainsKey(demon))
                {
                    demons[demon] = demonsPowerDemage;
                }
            }
            var orderedDemons = demons.OrderBy(p => p.Key);
            foreach (var demo in orderedDemons)
            {
                string name = demo.Key;
                foreach (var item in demo.Value)
                {
                    double health = item.Key;
                    double damage = item.Value;
                    Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
                }

            }
        }
    }
}

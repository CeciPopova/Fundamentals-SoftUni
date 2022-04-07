using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace P04._Star_Enigma
{
    internal class Program
    {
        public static object MatchColection { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int attackCounter = 0;
            int destructionCounter = 0;
            for (int i = 0; i < n; i++)
            {


                string encreptedMessage = Console.ReadLine();
                string encreptedMessageLower = encreptedMessage.ToLower();
                char[] encript = encreptedMessageLower.ToCharArray();
                //char[] letters = {'s','t','a','r'};

                int count = 0;
                for (int j = 0; j < encript.Length; j++)
                {
                    if (encript[j] == 's' || encript[j] == 't' || encript[j] == 'a' || encript[j] == 'r')
                    {
                        count++;
                    }
                }
                List<char> lettersValue = new List<char>();
                for (int j = 0; j < encreptedMessage.Length; j++)
                {
                    char currChar = encreptedMessage[j];
                    int charrValue = currChar - count;
                    char currCharValue = (char)charrValue;
                    lettersValue.Add(currCharValue);

                }
                string decriptedMessage = string.Join("", lettersValue);

                string pattern = @"@([A-Za-z]+)[^@\-!:>]*?:(\d+)[^@\-!:>]*?!([A|D])![^@\-!:>]*?->(\d+)";

                MatchCollection matchCollection = Regex.Matches(decriptedMessage, pattern);

                foreach (Match match in matchCollection)
                {
                    string planetName = match.Groups[1].Value;
                    int planetPopulation = int.Parse(match.Groups[2].Value);
                    string attackType = match.Groups[3].Value;

                    if (attackType == "A")
                    {
                        attackCounter++;
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destructionCounter++;
                        destroyedPlanets.Add(planetName);
                    }
                    int soldersCount = int.Parse(match.Groups[4].Value);
                }
            
                
            }
            Console.WriteLine($"Attacked planets: {attackCounter}");
            foreach (var item in attackedPlanets.OrderBy(p=>p))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destructionCounter}");
            foreach (var item in destroyedPlanets.OrderBy(p=>p))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}

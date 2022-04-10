using System;
using System.Collections.Generic;
using System.Linq;

namespace E5._03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();
            Dictionary<string, City> tardets = new Dictionary<string, City>();
            while (command!="Sail")
            {
                string[] cmndArgs = command
                    .Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string cityName = cmndArgs[0];  
                int population = int.Parse(cmndArgs[1]);
                int gold = int.Parse(cmndArgs[2]);
                City City = new City(cityName, population, gold);
                if (tardets.ContainsKey(cityName))
                {
                    tardets[cityName].Population += population;
                    tardets[cityName].Golg+=gold;   
                }
                else
                {
                    tardets.Add(cityName, City);
                }
                command = Console.ReadLine();
            }
            string instruction = Console.ReadLine();
            while (instruction!="End")
            {
                string[] instructionArgs = instruction
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = instructionArgs[0];
                if (action== "Plunder")
                {
                    string cityName =instructionArgs[1];    
                    int people = int.Parse(instructionArgs[2]); 
                    int gold = int.Parse(instructionArgs[3]);
                    if (tardets.ContainsKey(cityName))
                    {
                        tardets[cityName].Population -= people;
                        tardets[cityName].Golg -= gold;
                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");
                        if (tardets[cityName].Golg<=0 || tardets[cityName].Population<=0)
                        {
                            tardets.Remove(cityName);
                            Console.WriteLine($"{cityName} has been wiped off the map!");
                        }
                    }
                }
                else if (action== "Prosper")
                {
                    string town = instructionArgs[1];   
                    int gold = int.Parse (instructionArgs[2]);  
                    if (tardets.ContainsKey(town))
                    {
                        if (gold<0)
                        {
                            Console.WriteLine($"Gold added cannot be a negative number!");
                            instruction = Console.ReadLine();
                            continue;
                        }
                        tardets[town].Golg += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {tardets[town].Golg} gold.");
                    }
                }
                instruction = Console.ReadLine();
            }
            if (tardets.Count==0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {tardets.Count} wealthy settlements to go to:");
                foreach (var target in tardets)
                {
                    Console.WriteLine($"{target.Key} -> Population: {target.Value.Population} citizens, Gold: {target.Value.Golg} kg");

                }
            }

        }
    }
    class City
    {
        public City(string cityName,int population, int gold)
        {
            this.Name = cityName;   
            this.Population = population;   
            this.Golg = gold;    
        }
        public string Name { get; set; }    
        public int Population { get; set; }
        public int Golg { get; set; }

    }
}

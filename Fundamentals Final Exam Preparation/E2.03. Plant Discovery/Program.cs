using System;
using System.Collections.Generic;
using System.Linq;

namespace E2._03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plants = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantsRating = new Dictionary<string, List<double>>();
          
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);
                List<double> rating = new List<double>();
                if (!plantsRating.ContainsKey(plantName))
                {
                    plantsRating.Add(plantName, rating);
                }
                if (plants.ContainsKey(plantName))
                {
                    plants[plantName] = rarity;
                }
                else
                {
                    plants.Add(plantName, rarity);
                }
            }
            string command = Console.ReadLine();
           
            while (command != "Exhibition")
            {
               
                string[] cmdArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string[] arguments = cmdArgs[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string plantName = arguments[0];
               
                if (action == "Rate")
                {
                    double rating = double.Parse(arguments[1]);
                    List<double> ratings = new List<double>();
                    ratings.Add(rating);
                    if (!plantsRating.ContainsKey(plantName))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        plantsRating[plantName].Add(rating);
                    }

                }
                else if (action == "Update")
                {
                    int newRarity = int.Parse(arguments[1]);
                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (action == "Reset")
                {
                    if (plantsRating.ContainsKey(plantName))
                    {
                        plantsRating[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                string plantName = item.Key;
                int rarity = item.Value;
                double rating = 0;
                if (plantsRating.ContainsKey(plantName))
                {
                    if (plantsRating[plantName].Any())
                    {
                        rating = plantsRating[plantName].Average();
                        
                    }
                 
                }
                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {rating:f2}");
            }
        }
    }

}

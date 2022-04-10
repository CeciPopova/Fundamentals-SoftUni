using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestCollection = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            int unlikedMeals = 0;   

            while (command != "Stop")
            {
                string[] cmndArds = command
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = cmndArds[0];
                string guest = cmndArds[1]; 
                string meal = cmndArds[2];  
                
                if (type=="Like")
                {

                    if (!guestCollection.ContainsKey(guest))
                    {
                        guestCollection.Add(guest, new List<string>());
                        guestCollection[guest].Add(meal);
                    }
                    else
                    {
                        if (!guestCollection[guest].Contains(meal))
                        {
                            guestCollection[guest].Add(meal);
                        }
                    }
                }
                else if (type=="Dislike")
                {
                   
                    if (guestCollection.ContainsKey(guest))
                    {
                        if (guestCollection[guest].Contains(meal))
                        {
                            unlikedMeals++;
                            guestCollection[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var guest in guestCollection)
            {
                if (guest.Value.Count == 0)
                {
                    Console.WriteLine($"{guest.Key}:");
                }
                else
                {
                    Console.Write($"{guest.Key}: ");
                    int count = 0;
                    for (int i = 0; i < guest.Value.Count; i++)
                    {

                        if (count == guest.Value.Count - 1)
                        {
                            Console.WriteLine($"{guest.Value[i]}");

                        }
                        else
                        {
                            Console.Write($"{guest.Value[i]}, ");
                        }
                        count++;
                    }
                }
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}"); 
        }
    }
}

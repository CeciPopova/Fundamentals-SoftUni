using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();  

            int maxHealthCapacity = int.Parse(Console.ReadLine());

            string command=Console.ReadLine();

            while (command != "Retire")
            {
                string[] arr = command.Split(" ");
                string action = arr[0];
                if (action == "Fire")
                {
                    int index = int.Parse(arr[1]);
                    int damage = int.Parse(arr[2]);
                    if (index >= 0 && index < warShip.Count)
                    {
                       int warShipSection = warShip[index];

                       warShipSection -= damage;
                        if (warShipSection <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                        }
                            
                    }

                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(arr[1]);
                    int endIndex = int.Parse(arr[2]);
                    int damage = int.Parse(arr[3]);

                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex > 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int currSection = pirateShip[i];
                            currSection -= damage;
                          
                            if (currSection <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }

                }
                else if (action == "Repair")
                {
                    int index = int.Parse(arr[1]);
                    int health = int.Parse(arr[2]);
                    if (index >= 0 && index < pirateShip.Count)
                    {
                        int currSection = pirateShip[index];
                        currSection += health;
                        if (currSection > maxHealthCapacity)
                        {
                            currSection = maxHealthCapacity;
                        }
                    }
                }
                else if (action == "Status")
                {
                    int count = 0;

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        double minHealthCapacity = 0.2 * maxHealthCapacity;
                        int currSection = pirateShip[i];    
                        if (currSection<minHealthCapacity)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }


                command = Console.ReadLine();
            }
            int pirateShipSum=pirateShip.Sum();
            int warShipSum=warShip.Sum();   
            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warShipSum}");
           


        }
    }
}

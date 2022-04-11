using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dungeonsRooms = Console.ReadLine().Split("|").ToList();
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < dungeonsRooms.Count; i++)
            {
                int bestRoom = i;
                

                string[] arr = dungeonsRooms[i].Split().ToArray();

                string monster = arr[0];    
                int num=int.Parse(arr[1]);

                if (monster=="potion")
                {
                    if ((health + num)>=100)
                    {
                        num = 100 - health;
                    
                    }
                    health += num;
                    Console.WriteLine($"You healed for {num} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (monster=="chest")
                {
                    bitcoins += num;
                    
                    Console.WriteLine($"You found {num} bitcoins.");
                }
                else
                {
                    health -= num;
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom+1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}

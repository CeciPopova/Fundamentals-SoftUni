using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> neighborhood = Console.ReadLine().Split("@").ToList();
            
            string command = Console.ReadLine();
            int index=0;

            while (command!="Love!")
            {
                string[] arr = command.Split().ToArray();
                string action=arr[0];   
                int lenght= int.Parse(arr[1]);
                index+=lenght;
                if (action == "Jump")
                {
                    if (index >= neighborhood.Count)
                    {
                        index = 0;
                    }
                    int house = int.Parse(neighborhood[index]);
                    if (house == 0)
                    {
                        Console.WriteLine($"Place {index} already had Valentine's day.");
                        command = Console.ReadLine();
                        continue;
                    }
                  
                    house -= 2;
                    neighborhood[index] = house.ToString();

                    if (house == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                    }

                }  
                command=Console.ReadLine(); 
            }
            Console.WriteLine($"Cupid's last position was {index}.");
            bool isValentine= true; 
            int houseCount= 0;  
            for (int i = 0; i < neighborhood.Count; i++)
            {
                int valentine=int.Parse(neighborhood[i]);
                if (valentine!=0)
                {
                    houseCount++;   
                    isValentine=false;
                }
                
            }
            if (isValentine)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}

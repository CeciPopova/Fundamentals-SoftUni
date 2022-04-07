using System;
using System.Collections.Generic;

namespace P05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> parkingMap = new Dictionary<string,string>();    
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] input=command.Split(' '); 
                string action=input[0]; 
               

                if (action=="register")
                {
                    string userName = input[1];
                    string licensePlateNumber = input[2];
                    if (!parkingMap.ContainsKey(userName))
                    {
                        parkingMap.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingMap[userName]}"); 
                        
                    }
                }
                else if (action == "unregister")
                {
                    string userName = input[1];
                  

                    if (!parkingMap.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        parkingMap.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }

                }
               
            }
            foreach (var item in parkingMap)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

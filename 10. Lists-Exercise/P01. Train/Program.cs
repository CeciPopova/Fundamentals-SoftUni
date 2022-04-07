using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] arr = command.Split(' ');
                string action = arr[0];

                if (action == "Add")
                {
                    int passengers = int.Parse(arr[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int input = int.Parse(action);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int oldPassenger = wagons[i];
                        if ((oldPassenger + input) <= maxCapacity)
                        {
                            wagons[i] += input;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
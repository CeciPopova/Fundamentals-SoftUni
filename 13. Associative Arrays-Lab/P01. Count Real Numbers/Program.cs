using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            SortedDictionary<int, int> occurencies = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (occurencies.ContainsKey(number))
                {
                    occurencies[number] += 1;
                }
                else
                {
                    occurencies.Add(number, 1);
                }
            }
            foreach (var item in occurencies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

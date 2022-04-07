using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> originalList = Console.ReadLine().Split("|").ToList();

            originalList.Reverse();


            List<string> list = new List<string>();
            foreach (string str in originalList)
            {
                string[] num = str.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                list.AddRange(num);
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}

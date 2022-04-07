using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();


            list.RemoveAll(n => n < 0);
            list.Reverse();
            if (list.Count>0)
            {
                Console.WriteLine(string.Join(" ",list));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1= Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> list2 = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            int longerCount=Math.Max(list1.Count, list2.Count);
            List<int> result=new List<int>();   


            for (int i = 0; i < longerCount; i++)
            {
                if (i<list1.Count)
                {
                    result.Add(list1[i]);   
                }
                if (i<list2.Count)
                {
                    result.Add(list2[i]);  
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

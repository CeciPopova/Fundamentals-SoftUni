using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string,int> occurancies = new Dictionary<string,int>();

            foreach (string word in words)
            {
                string lowerCase = word.ToLower();

                if (occurancies.ContainsKey(lowerCase))
                {
                    occurancies[lowerCase] ++;
                }
                else
                {
                    occurancies.Add(lowerCase, 1);
                }
            }
           string[] result = occurancies.Where(x => x.Value % 2 != 0)
                .Select(x => x.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

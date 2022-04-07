using System;
using System.Linq;

namespace P02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] words = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string result = string.Empty;
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}

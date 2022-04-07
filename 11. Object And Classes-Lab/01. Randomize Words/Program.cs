using System;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(' ').ToArray();

           Random random = new Random(words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                int currPosition = random.Next(words.Length);
                string temp = words[i]; 
                words[i] = words[currPosition]; 
                words[currPosition] = temp; 

            }
            Console.WriteLine(string.Join("\n",words));
        }
    }
}

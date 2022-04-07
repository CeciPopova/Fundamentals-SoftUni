using System;
using System.Linq;

namespace P02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
            Console.WriteLine(GetVowelsCount(text));
        }
        static int GetVowelsCount(string text)
        {
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };

            int count = 0;  
            foreach(char ch in text.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }
            return count;   
        }
    }
}

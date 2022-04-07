using System;
using System.Collections.Generic;

namespace P01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();

            Dictionary<char,int> dict = new Dictionary<char,int>();

            for (int i = 0; i < text.Length; i++)
            {

            char currChar=text[i];  
                
                if (currChar!=' ')
                {
                    if (!dict.ContainsKey(currChar))
                    {
                        dict.Add(currChar, 1);
                    }
                    else
                    {
                        dict[currChar]++;
                    }
                }

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E3._02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            Regex regex = new Regex(@"([@|#])(?<firstWord>[A-za-z]{3,})(?:\1)(?:\1)(?<secondWord>[A-Za-z]{3,})(?:\1)");
            MatchCollection matches = regex.Matches(input);
            Dictionary<string, string> mirorrWords = new Dictionary<string, string>();
            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["firstWord"].Value;
                    string secondWord = match.Groups["secondWord"].Value.Trim();
                    string reverseWord = string.Join("", secondWord.Reverse());
                    if (firstWord==reverseWord)
                    {
                        mirorrWords.Add(firstWord, secondWord);
                    }
                }
            }
            if (matches.Count==0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if (mirorrWords.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                int count = 0;
                foreach (var item in mirorrWords)
                {
                    count++;
                    if (count!=mirorrWords.Count)
                    {
                        Console.Write($"{item.Key} <=> {item.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Key} <=> {item.Value}");
                    }
                }
            }
        }
    }
}

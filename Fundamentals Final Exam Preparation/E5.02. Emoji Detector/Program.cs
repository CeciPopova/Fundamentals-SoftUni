using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E5._02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long coolThreshold = 1;
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
               
                if (char.IsDigit(currChar))
                {
                    // int currDigit = currChar - '0';
                    long currDigit = long.Parse(currChar.ToString());
                    coolThreshold *=currDigit;
                  
                }
            }
            Regex regex = new Regex(@"(:{2}|\*{2})([A-Z][a-z]{2,})(\1)");
           
            Dictionary<string, long> emojis = new Dictionary<string, long>();
            MatchCollection validEmojis = regex.Matches(input); 
            foreach (Match match in validEmojis)
            {
                if (match.Success)
                {
                    long coolnes = 0;
                    string emoji = match.Groups[2].Value;
                    for (int i = 0; i < emoji.Length; i++)
                    {
                        char currChar = emoji[i];
                        long currDigit = (long)currChar;
                        coolnes += currDigit;
                    }
                    if (coolnes>coolThreshold)
                    {
                        emojis.Add(match.Value, coolnes);
                    }
                   
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");
            foreach (var item in emojis)
            {
                    Console.WriteLine(item.Key);
            }

        }
    }
}

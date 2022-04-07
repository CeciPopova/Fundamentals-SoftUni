using System;
using System.Linq;

namespace P08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal sum = 0;
            foreach (var word in words)
            {
              sum +=CalculateSingleWordSum(word);
            }
            Console.WriteLine($"{sum:f2}");

        }
        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length-1];
            int num = int.Parse(word.Substring(1,word.Length-2));
            
            int firstLetterPosition = GetAlfabeticalPositionOfCharacter(firstLetter);   
            int lastLetterPosition = GetAlfabeticalPositionOfCharacter(lastLetter);

            if (Char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPosition;
            }
            else if (Char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPosition;
            }

            if (Char.IsUpper(lastLetter))
            {
                sum -= lastLetterPosition;
            }
            else if (Char.IsLower(lastLetter))
            {
                sum+= lastLetterPosition;
            }
            return sum;
            
        }
        static int GetAlfabeticalPositionOfCharacter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }
            else
            {
                char chCh = Char.ToLower(ch);
                return (int)chCh-96;
            }
        }
    }
}

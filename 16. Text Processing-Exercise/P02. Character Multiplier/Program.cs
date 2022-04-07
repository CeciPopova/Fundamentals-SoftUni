using System;
using System.Linq;

namespace P02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string firstStr = inputs[0];    
            string secondStr = inputs[1];
            int sum = 0;
            if (firstStr.Length==secondStr.Length)
            {
                Console.WriteLine(SumMultipliedChars(firstStr,secondStr));
            }
            else
            {
                if (firstStr.Length>secondStr.Length)
                {
                    for (int i = secondStr.Length; i < firstStr.Length; i++)
                    {
                        int currNum = (int)firstStr[i];
                        sum += currNum;
                    }
                }
                else
                {
                    for (int i = firstStr.Length; i < secondStr.Length; i++)
                    {
                        int currNum = (int)secondStr[i];
                        sum += currNum;
                    }
                }
                sum += SumMultipliedChars(firstStr, secondStr);
                Console.WriteLine(sum);
            }
            
        }
        static int SumMultipliedChars(string firstStr, string secondStr)
        {
            int sum = 0;
            int shorterLenght = Math.Min(firstStr.Length, secondStr.Length);
            for (int i = 0; i < shorterLenght; i++)
            {
                int firstNum = (int)firstStr[i]; 
                int secondNum = (int)secondStr[i];
                sum += firstNum * secondNum;
            }
            return sum; 
        }
    }
}

using System;

namespace MoreExercise02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            long firsSum = 0;
            long secondSum = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] number=input.Split(' ');   
                long firstNumber=long.Parse(number[0]); 
                long secondNumber=long.Parse(number[1]);

                if (firstNumber>secondNumber)
                {
                    while (firstNumber!=0)
                    {
                        firsSum += firstNumber % 10;
                        firstNumber /= 10;  
                    }
                    Console.WriteLine(Math.Abs(firsSum));
                    firsSum = 0;
                }
                else
                {
                    while (secondNumber != 0)
                    {
                        secondSum += secondNumber % 10;
                        secondNumber /= 10; 
                    }
                    Console.WriteLine(Math.Abs(secondSum));
                    secondSum = 0;
                }

            }
        }
    }
}

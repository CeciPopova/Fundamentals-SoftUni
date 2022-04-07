using System;

namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfEvenDigits = GetSumOfEvenDigits(number);
            int sumOfOddDigits = GetSumOfOddDigits(number); 
            int result = Math.Abs(sumOfEvenDigits * sumOfOddDigits);
            Console.WriteLine(result);  
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number != 0) 
            {
                int digit = number % 10;

                if (digit%2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum; 
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}

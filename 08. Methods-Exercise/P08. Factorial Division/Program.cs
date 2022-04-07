using System;

namespace P08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double factOfFirstNum = CalculateFactorial(firstNum);
            double factOfSecondNum= CalculateFactorial(secondNum); 
            double result=factOfFirstNum/factOfSecondNum;  
            Console.WriteLine($"{ result:f2}");  
            
        }
        static double CalculateFactorial(int number)
        {
            double factorial = 1;

            while (number>0)
            {
                factorial*=number;
                number--;   
            }

            return factorial;  
            
        }
    }
}

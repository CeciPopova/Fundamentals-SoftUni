using System;

namespace P08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num=double.Parse(Console.ReadLine());
            int power=int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(num,power));
            
        }
        static double RaiseToPower(double num,int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= num;
            }
            return result;  
        }
    }
}

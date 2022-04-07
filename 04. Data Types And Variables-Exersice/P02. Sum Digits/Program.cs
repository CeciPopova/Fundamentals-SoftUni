using System;

namespace P02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            int sum = 0;

            while (n>0)
            {
                int currDigit = n % 10;
                n = n / 10;
                sum += currDigit;
            }
            Console.WriteLine(sum);
        }
    }
}

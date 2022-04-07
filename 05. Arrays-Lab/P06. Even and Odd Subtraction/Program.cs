using System;
using System.Linq;

namespace P06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num=arr[i]; 
                if (num%2==0)
                {
                    sumEven+=num;
                }
                else
                {
                    sumOdd+=num;
                }
            }
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}

using System;
using System.Linq;

namespace P03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double[] arr=Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                double num = arr[i];
                double number = Math.Round(num, MidpointRounding.AwayFromZero);
                
                    
                Console.WriteLine($"{num} => {number}");
            }
        }
    }
}

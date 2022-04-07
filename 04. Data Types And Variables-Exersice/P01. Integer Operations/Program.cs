using System;

namespace P01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth=int.Parse(Console.ReadLine());

            long productOne = first + second;
            long productTwo = productOne / third;  
            long productThree = productTwo * fourth;

            Console.WriteLine(productThree);
        }
    }
}

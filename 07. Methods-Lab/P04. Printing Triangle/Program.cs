using System;

namespace P04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                PrintLine(1, i);
            }
            for (int j = num; j >=1; j--)
            {
                PrintLine(1,j);
            }

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();    
        }
    }
}

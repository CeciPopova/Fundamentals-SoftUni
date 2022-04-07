using System;
using System.Linq;

namespace P05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] arr=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                
                if (num%2==0)
                {
                    sum += num;
                }

            }
            Console.WriteLine(sum); 
        }
    }
}

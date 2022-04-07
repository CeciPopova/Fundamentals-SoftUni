using System;

namespace P04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string[] reverseArray=new string[arr.Length];

            for (int i = arr.Length-1; i >= 0; i--)
            {
                reverseArray[arr.Length - 1 - i] = arr[i];
            }
            Console.WriteLine(string.Join(" ",reverseArray));
        }
    }
}

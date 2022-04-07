using System;
using System.Linq;

namespace P08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (arr.Length>1)
            {


                int[] condensedArr = new int[arr.Length-1];

                for (int i = 0; i < condensedArr.Length; i++)
                {
                    condensedArr[i] = arr[i + 1] + arr[i];


                }
                arr = condensedArr;
            }
            Console.WriteLine(string.Join(" ",arr)); 
        }
    }
}

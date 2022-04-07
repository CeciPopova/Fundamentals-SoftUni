using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] arr = command.Split(' ');
                string action=arr[0];
                if (action=="Delete")
                {
                    int numToDelete = int.Parse(arr[1]);
                    numbers.RemoveAll(n => n == numToDelete);

                }
                else if (action=="Insert")
                {
                    int numToInsert=int.Parse(arr[1]); 
                    int position=int.Parse(arr[2]);
                    numbers.Insert(position, numToInsert);  

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers)); 
        }
    }
}

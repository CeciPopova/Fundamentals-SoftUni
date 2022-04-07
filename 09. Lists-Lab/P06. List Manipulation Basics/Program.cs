using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse) 
                .ToList();  

            string command=Console.ReadLine();

            while (command!="end")
            {
                
                string[] arr = command.Split(' ');
                string action=arr[0];    

                if (action=="Add")
                { 
                    int numberToAdd=int.Parse(arr[1]);    
                    numbers.Add(numberToAdd);
                
                }
                else if (action=="Remove")
                {
                    int numberToRemove=int.Parse(arr[1]); 
                    numbers.Remove(numberToRemove);
                }
                else if (action=="RemoveAt")
                {
                    int index=int.Parse(arr[1]);
                    numbers.RemoveAt(index);
                }
                else if (action=="Insert")
                {
                    int index = int.Parse(arr[2]);
                    int element = int.Parse(arr[1]);  
                    numbers.Insert(index,element); 
                }

                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();  

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] arr=command.Split(' '); 
                string action = arr[0];
                

                if (action=="Add")
                {
                    int numToAdd = int.Parse(arr[1]);
                    numbers.Add(numToAdd);  
                }
                else if (action=="Insert")
                {
                    int numToInsert = int.Parse(arr[1]);
                    int index = int.Parse(arr[2]);
                    if (index<0||index>numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, numToInsert);
                    }
                    
                }
                else if (action=="Remove")
                {
                    int index=int.Parse(arr[1]);
                    if (index <0 || index > numbers.Count )
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (action=="Shift")
                {
                    string leftOrRight=arr[1];
                    int count = int.Parse (arr[2]);
                    if (leftOrRight=="left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            ShiftLeft(numbers);
                        }
                    }
                    else if (leftOrRight=="right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            ShiftRight(numbers);
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void ShiftLeft(List<int> num )
        {
          
                int firsNum = num[0];
               
                for (int i = 1; i < num.Count; i++)
                {

                   num[i-1]= num[i];
                   

                }
                num[num.Count-1] = firsNum; 
             
        }
        static void ShiftRight(List<int> num)
        {

            int lastNum = num[num.Count - 1];


            for (int i = num.Count - 1; i > 0; i--)
            {
                num[i] = num[i - 1];
            }
            num[0] = lastNum;
        }
    }
}

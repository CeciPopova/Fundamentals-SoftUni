using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            bool isChange = false;  

            while (command!="end")
            {
                string[] arr=command.Split(); 
                string action=arr[0];


                if (action == "Add")
                {
                    int numberToAdd = int.Parse(arr[1]);
                    numbers.Add(numberToAdd);
                    isChange=true;  
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(arr[1]);
                    numbers.Remove(numberToRemove);
                    isChange = true;    
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(arr[1]);
                    numbers.RemoveAt(index);
                    isChange = true;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(arr[2]);
                    int element = int.Parse(arr[1]);
                    numbers.Insert(index, element);
                    isChange = true;
                }
                if (action=="Contains")
                {
                    int containsNumber = int.Parse(arr[1]);
                    if (numbers.Contains(containsNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action=="PrintEven")
                {
                    PrintAllEvenNumbers(numbers);
                    
                }
                else if (action=="PrintOdd")
                {
                    PrintAllOddNumbers(numbers);
                    
                }
                else if (action=="GetSum")
                {
                    GetTheSumOfAllNumbers(numbers);
                    
                }
                else if (action=="Filter")
                {
                    string condition=arr[1]; 
                    int numToCompare=int.Parse(arr[2]);
                    FilterNumbersByCondition(numbers, condition, numToCompare);
                  
                }



                command = Console.ReadLine();
            }
            if (isChange)
            {
                Console.WriteLine(string.Join(" ",numbers));
            } 

        }
        static void PrintAllEvenNumbers(List<int> numbers)
        {
            int n= numbers.Count(); 
            List<int> result= new List<int>();
            for (int i = 0; i < n; i++)
            {
                int curNum= numbers[i];
                if (curNum%2==0)
                {
                    result.Add(curNum);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
        static void PrintAllOddNumbers(List<int> numbers)
        {
            int n = numbers.Count();
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int curNum = numbers[i];
                if (curNum % 2 != 0)
                {
                    result.Add(curNum);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
        static void GetTheSumOfAllNumbers(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                sum+=currNum;
            }
            Console.WriteLine(sum);
        }
        static void FilterNumbersByCondition(List<int> numbers,string condition,int numToCompare)
        {
            List<int> result = new List<int>(); 
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                if (condition==">")
                {
                    if (currNum>numToCompare)
                    {
                        result.Add(currNum);
                    }
                }
                else if (condition=="<")
                {
                    if (currNum<numToCompare)
                    {
                        result.Add(currNum);
                    }
                }
                else if (condition==">=")
                {
                    if (currNum>=numToCompare)
                    {
                        result.Add(currNum);
                    }
                }
                else if (condition=="<=")
                {
                    if (currNum<=numToCompare)
                    {
                        result.Add(currNum);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));  
        }
    }
}

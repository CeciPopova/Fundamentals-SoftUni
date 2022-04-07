using System;
using System.Collections.Generic;

namespace P03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numOfCommands= int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < numOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] arr= command.Split(' ');   
                string name= arr[0];
                string action = arr[2];   
                if (action=="going!")
                {
                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        list.Add(name);
                    }
                   
                    
                }
                else if (action=="not")
                {
                    if (list.Contains(name))
                    {
                        list.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    
                }
              

            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();  

            string command=Console.ReadLine();

            while (command!="End")
            {
                string[] arr = command.Split(); 
               string action=arr[0];    

                if (action=="Shoot")
                {
                    int index= int.Parse(arr[1]);
                    int power= int.Parse(arr[2]);
                    if (index>=0&&index<targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index]<=0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (action=="Add")
                {
                    int index = int.Parse(arr[1]);
                    int value = int.Parse(arr[2]);
                    if (index>=0&&index<targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (action=="Strike")
                {
                    int index=int.Parse(arr[1]);
                    int radius= int.Parse(arr[2]);
                    int startIndex = index - radius;
                    int endIndex = index + radius;
                    int count = radius * 2 + 1;
                    if (startIndex>=0 && endIndex<targets.Count)
                    {
                        targets.RemoveRange(startIndex, count);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        command=Console.ReadLine();
                        continue;
                    }

                }


                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join("|",targets));
        }
    }
}

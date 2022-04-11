using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers=Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double sum = 0;
            List<double> newList = new List<double>();
            for (int i = 0; i < numbers.Count; i++)
            {
               double currNum=numbers[i];  
                sum+=currNum;
            }
            double averageNum=sum/numbers.Count*1.0;
            for (int i = 0; i < numbers.Count; i++)
            {
                
                double currNum=numbers[i];
                if (currNum>averageNum)
                {
                   
                    newList.Add(currNum);   
                }
            }
            if (newList.Count<1)
            {
                Console.WriteLine("No");
                return;
            }
            newList.Sort();
            newList.Reverse();
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList.Count > 5)
                {
                    while (newList.Count != 5)
                    {
                        newList.RemoveAt(newList.Count - 1);
                    }
                }
                
            } 
            
                    Console.WriteLine(string.Join(" ", newList));
                
            
           

        }
    }
}

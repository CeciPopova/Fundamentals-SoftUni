using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            Dictionary<string, List<string>> companiesList =new Dictionary<string,List<string>>();
            while (command!="End")
            {
                string[] input = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName=input[0];    
                string employersId=input[1];

                if (!companiesList.ContainsKey(companyName))
                {
                    companiesList.Add(companyName, new List<string>() { employersId });
                }
                else
                {
                    if (!companiesList[companyName].Contains(employersId))
                    {
                        companiesList[companyName].Add(employersId);
                    }
                    
                }


                command = Console.ReadLine();
            }
            foreach (var item in companiesList)
            {
                Console.WriteLine(item.Key);
                foreach (var employer in item.Value)
                {
                    Console.WriteLine($"-- {employer}");
                }
            }
           
        }
    }
}

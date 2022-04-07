using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();
            for (int i = 1; i <= n; i++)
            {
                string studentsName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsData.ContainsKey(studentsName))
                {
                    studentsData.Add(studentsName, new List<double>() {grade});
                }
                else
                {
                    studentsData[studentsName].Add(grade);
                }

            }
            foreach (var kvp in studentsData)
            {
                if (kvp.Value.Average()>=4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
                }
                
            }
        }
    }
}

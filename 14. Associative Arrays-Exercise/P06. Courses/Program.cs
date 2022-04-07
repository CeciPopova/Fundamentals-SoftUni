using System;
using System.Collections.Generic;

namespace P06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Dictionary<string,List<string>> studentsDataBase=new Dictionary<string,List<string>>(); 
            
            while (input!="end")
            {
                string[] data = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName=data[0];  
                string studentName =data[1];

                if (!studentsDataBase.ContainsKey(courseName))
                {
                   
                  
                    studentsDataBase.Add(courseName, new List<string>() {studentName});
                }
                else
                {
                   
                    studentsDataBase[courseName].Add(studentName);  
                }

                input= Console.ReadLine();
            }
            foreach (var item in studentsDataBase)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}

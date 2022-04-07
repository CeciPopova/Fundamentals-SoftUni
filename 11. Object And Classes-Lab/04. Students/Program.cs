using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    { 
        internal class Student
        {
            public string FistName { get; set; }    
            public string LastName { get; set; }    
            public int Age { get; set; }    
            public string HomeTown { get; set; }    

        }
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command!="end")
            {
                string[] vs = command.Split(' ');
                string firstName=vs[0]; 
                string lastName=vs[1];  
                int age=int.Parse(vs[2]);
                string homeTown=vs[3];  
               

                Student student=new Student();

                student.FistName=firstName; 
                student.LastName=lastName;  
                student.Age=age;    
                student.HomeTown=homeTown;  

                students.Add(student);  

                command = Console.ReadLine();
            }
            string cityName=Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown==cityName)
                {
                    Console.WriteLine($"{student.FistName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}

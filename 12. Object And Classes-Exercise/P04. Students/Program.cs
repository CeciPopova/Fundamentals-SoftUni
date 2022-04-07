using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Students
{
    internal class Program
    {
        class Student
        {
            public Student(string firstName,string secondName,double grade)
            {
                this.FirstName = firstName;
                this.SecondName = secondName;
                this.Grade = grade; 
            }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {SecondName}: {Grade:f2}";
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int countOfStudents= int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= countOfStudents; i++)
            {
                string[] studentsData = Console.ReadLine().Split().ToArray();

                string firstName=studentsData[0];   
                string lastName=studentsData[1];
                double grade = double.Parse(studentsData[2]);
                Student student = new Student(firstName, lastName, grade);

                students.Add(student);  
            }
            students = students.OrderByDescending(s => s.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,students));
        }
    }
}

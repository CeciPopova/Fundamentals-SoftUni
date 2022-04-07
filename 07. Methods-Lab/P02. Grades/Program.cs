using System;

namespace P02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade=double.Parse(Console.ReadLine());
            PrintGradeDefinition(grade);
        }
        static void PrintGradeDefinition(double deff)
        {
            if (deff<3)
            {
                Console.WriteLine("Fail");
            }
            else if (deff<3.5)
            {
                Console.WriteLine("Poor");
            }
            else if (deff<4.5)
            {
                Console.WriteLine("Good");
            }
            else if (deff<5.5)
            {
                Console.WriteLine("Very good");
            }
            else if (deff<=6)
            {
                Console.WriteLine("Excellent");
            }
            

            
        }
    }
}

using System;

namespace Mid_Exam01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int studentsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hoursNeeded = 0;
            while (studentsCount>0)
            {
                studentsCount -= studentsPerHour;
                hoursNeeded++;

                if (hoursNeeded%4==0)
                {
                    hoursNeeded++;
                }
            }
            Console.WriteLine($"Time needed: {hoursNeeded}h.");  
           
            
        }
    }
}

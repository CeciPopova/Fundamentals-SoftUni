using System;

namespace MidExam01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents=int.Parse(Console.ReadLine());
            double courseLectures= double.Parse(Console.ReadLine());
            double additionalBonus= double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double totalBonus = 0;
            double bestStudentAttendance = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                double studentAttendances= double.Parse(Console.ReadLine());    

                totalBonus =studentAttendances / courseLectures * (5 + additionalBonus);

                if (totalBonus>maxBonus)
                {
                    maxBonus = totalBonus;
                    bestStudentAttendance = studentAttendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {Math.Round(bestStudentAttendance)} lectures.");
        }
    }
}

using System;

namespace P01.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double bugdet = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int countBelts = studentsCount - studentsCount / 6;


            double totalPrice = (lightsabrePrice * (Math.Ceiling(studentsCount * 1.1))) + (robesPrice * studentsCount) + (beltsPrice * countBelts);

            if (bugdet >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs(totalPrice - bugdet):f2}lv more.");
            }
        }
    }
}

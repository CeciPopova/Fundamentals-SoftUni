using System;

namespace P01._Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());
            decimal flourCount = numberOfStudents;
            for (int i = 1; i <= numberOfStudents; i++)
            {
                if (i % 5 == 0)
                {
                    flourCount--;
                }
                
            }
            decimal apronsForStudents = numberOfStudents + (0.20M * numberOfStudents);
            decimal roundedApronsForStudents = Math.Ceiling(apronsForStudents);
            decimal totalApronPrice = apronPrice * roundedApronsForStudents;
            
            decimal currBudget =totalApronPrice + eggPrice * 10 * numberOfStudents + flourCount*flourPrice;


            if (currBudget > budget)
            {
                decimal neededMoney = currBudget-budget;
               
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
            else
            {
                Console.WriteLine($"Items purchased for {currBudget:f2}$.");
            }
        }
    }
}

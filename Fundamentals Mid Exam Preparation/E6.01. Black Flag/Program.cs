using System;

namespace MidExam01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int daysOfPlonder = int.Parse(Console.ReadLine());  
          double dailyplonder = double.Parse(Console.ReadLine()); 
          double expectedPlunder=double.Parse(Console.ReadLine());

            double realPlunder = 0;


            for (int i = 1; i <= daysOfPlonder; i++)
            {
                
                realPlunder += dailyplonder;
                if (i%3==0)
                {
                    realPlunder = realPlunder + 0.5 * dailyplonder;

                }
                if (i%5==0)
                {
                    realPlunder = realPlunder - 0.3 * realPlunder;
                }
            }
            if (realPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {realPlunder:f2} plunder gained.");
            }
            else
            {
               double percentage = realPlunder/expectedPlunder*100; 
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}

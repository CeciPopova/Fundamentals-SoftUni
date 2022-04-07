using System;

namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            int totalWaterLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                totalWaterLiters += quantitiesOfWater;
                if (totalWaterLiters>255)
                {
                    totalWaterLiters -= quantitiesOfWater;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
               

            }
            Console.WriteLine(totalWaterLiters);
        }
    }
}

using System;

namespace P01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] dayOfWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"

            };
            int n = int.Parse(Console.ReadLine());

            if (n<1||n>7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(dayOfWeek[n-1]);
            }

            
        }
    }
}

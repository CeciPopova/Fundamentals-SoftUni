using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minits = int.Parse(Console.ReadLine());

            minits += 30;
            if (minits>59)
            {
                hour += 1;
                minits -= 60;
            }
            if (hour>23)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minits:d2}");
         
        }
    }
}

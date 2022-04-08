using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            int tempNumber=number;
            int factorialSum = 0;

            while (tempNumber>0)
            {
                int currNumber = tempNumber % 10;
                tempNumber /= 10;

                int curFactNum = 1;

                for (int i = 1; i <= currNumber; i++)
                {
                    curFactNum *= i;
                }
                factorialSum+=curFactNum;
            }
            if (factorialSum==number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

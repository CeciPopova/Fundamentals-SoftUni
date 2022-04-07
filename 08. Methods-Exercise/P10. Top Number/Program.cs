using System;

namespace P10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int end = int.Parse(Console.ReadLine());


            for (int i = 1; i <= end; i++)
            {
                string number = i.ToString();
                int sumOfDigits = 0;
                bool isOdd = false;
                foreach (var digit in number)
                {
                    int currDiggit  = (int)digit;
                    if (currDiggit % 2 != 0 )
                    {
                        isOdd = true;
                    }
                    sumOfDigits += currDiggit;
                }
                if (isOdd && sumOfDigits % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
       
    }
}

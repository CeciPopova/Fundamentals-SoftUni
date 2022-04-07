using System;

namespace P01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmalesOfThreeNumbers(firstNum, secondNum ,thirdNum));
        }
        static int GetSmalesOfThreeNumbers(int a, int b,int c)
        {
            int minNum = int.MaxValue;
            if (a<minNum)
            {
                minNum = a;
            }
            if (b<minNum)
            {
                minNum=b;   
            }
            if (c<minNum)
            {
                minNum=(c);
            }
            return minNum;  
        }
    }
}

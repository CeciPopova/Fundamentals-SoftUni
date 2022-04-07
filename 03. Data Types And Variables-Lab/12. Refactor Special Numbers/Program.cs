using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int currNum = 0;
            bool toe = false;
            for (int i = 1; i<= num; i++)
{
                currNum = i;
                while (i > 0)
{
                    sum += i % 10;
                    i = i / 10;
                }
                toe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currNum, toe);
                sum = 0;
                i = currNum;
            }

           
        }
    }
}

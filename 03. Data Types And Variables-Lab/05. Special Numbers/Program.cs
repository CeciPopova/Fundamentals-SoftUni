using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                num = i;
                int sum = 0;
                while (num>0)
                {
                    int currDigit = num % 10;
                    num /= 10;
                    sum+=currDigit;
                }
                bool isSpecial = false;
                if (sum==5||sum==7||sum==11)
                {
                    isSpecial = true;
                }
                else
                {
                        isSpecial=false;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}

using System;
using System.Linq;
using System.Text;

namespace P05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            string longNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int temp = 0;

            if (num == 0 || longNum==" ")
            {
                Console.WriteLine(0);
                return;
            }
            foreach (var item in longNum.Reverse())
            {
                int currDigit = int.Parse(item.ToString());
                int result = currDigit * num + temp;
                int resultDigit = result % 10;
                temp = result / 10;
                sb.Insert(0,resultDigit);

            }
            if (temp>0)
            {
                sb.Insert(0,temp);
            }

            Console.WriteLine(sb);
        }
    }
}

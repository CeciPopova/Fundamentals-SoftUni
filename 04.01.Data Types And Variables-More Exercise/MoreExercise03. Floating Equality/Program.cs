using System;

namespace MoreExercise03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precision = 0.000001M;
            decimal firsNumber=decimal.Parse(Console.ReadLine());
            decimal secondNumber=decimal.Parse(Console.ReadLine());

            decimal result=Math.Abs(firsNumber-secondNumber);
            if (result>=precision)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}

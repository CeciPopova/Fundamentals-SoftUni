using System;

namespace P03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());

            if (command=="add")
            {
                AddNumbers(num1,num2);
            }
            else if (command=="subtract")
            {
                SubtractNumbers(num1, num2);
            }
            else if (command=="multiply")
            {
                MultiplyNumbers(num1, num2);
            }
            else if (command=="divide")
            {
                DivideNumbers(num1, num2);
            }
        }
        static void AddNumbers(int a,int b )
        {
            Console.WriteLine(a+b);
        }
        static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(a-b); 
        }
        static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void DivideNumbers( int a, int b)
        { 
            Console.WriteLine(a/b); 

        }  
    }
}

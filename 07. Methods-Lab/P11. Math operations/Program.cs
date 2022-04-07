using System;

namespace P11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());   
            string operation = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(num1,operation,num2));
        }
        static double Calculate(int a, string operation ,int b)
        {
            double result = 0;

            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else if (operation == "/")
            {
                result = a / b;
            }
            return result;  
        }
    }
}

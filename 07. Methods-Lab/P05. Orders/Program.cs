using System;

namespace P05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product=Console.ReadLine();
            int quantity=int.Parse(Console.ReadLine());
            if (product=="coffee")
            {
                PrintOrderTotalPrice(quantity, 1.50);
            }
            else if (product=="water")
            {
                PrintOrderTotalPrice(quantity, 1.00);
            }
            else if (product=="coke")
            {
                PrintOrderTotalPrice(quantity, 1.40);
            }
            else if (product=="snacks")
            {
                PrintOrderTotalPrice(quantity, 2.00);
            }
        }
        static void PrintOrderTotalPrice(int quantity,double price)
        {
            Console.WriteLine($"{(quantity*price):f2}");
        }
    }
}

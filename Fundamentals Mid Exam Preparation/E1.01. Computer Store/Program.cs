using System;

namespace Mid_Exam01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command= Console.ReadLine();
            decimal partsPriceWithoutTax = 0;
           
            while (command!="special"&&command!="regular")
            {
               decimal currPartPrice=decimal.Parse(command);
                if (currPartPrice<0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    partsPriceWithoutTax += currPartPrice;
                }
               
                command = Console.ReadLine();
            }
            decimal taxes = 0.20M * partsPriceWithoutTax;
            decimal totalPrice = partsPriceWithoutTax + taxes;
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                if (command == "special")
                {
                    totalPrice *= 0.90M;
                }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {partsPriceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            
            string input=Console.ReadLine();
            while (input!="buy")
            {
                string[] productData = input.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();   
                string product = productData[0];    
                double price = double.Parse(productData[1]);
                int quantity = int.Parse(productData[2]);
               

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double> { price,quantity}); 
                }
                else
                {
                 
                    products[product][0] = price;    
                    products[product][1] += quantity;    
                    
                }


                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace E4._02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"(@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)");

                Match match = regex.Match(input);
            
                if (match.Success)
                {
                     
                    char[] digits = input.Where(x => char.IsDigit(x)).ToArray();
                    string productGroup = string.Join("", digits);
                    if (productGroup.Length!=0)
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

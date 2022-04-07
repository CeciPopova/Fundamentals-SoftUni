using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double length = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
           double width=double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double heigth= double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            
           double volume = (length * width * heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}

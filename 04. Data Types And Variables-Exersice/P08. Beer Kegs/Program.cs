using System;

namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string bestBeerKeg=string.Empty;
            double bestVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string beerKegsType = Console.ReadLine();
                double radius=double.Parse(Console.ReadLine());
                long height=long.Parse(Console.ReadLine());

                double volume = Math.PI *Math.Pow(radius,2) * height;
                if (volume>bestVolume)
                {
                    bestBeerKeg = beerKegsType;
                    bestVolume = volume;    
                }
            }
            Console.WriteLine(bestBeerKeg); 
        }
    }
}

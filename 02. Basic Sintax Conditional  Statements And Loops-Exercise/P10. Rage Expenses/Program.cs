using System;

namespace P10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            int headset = lostGamesCount / 2;
            int mouse = lostGamesCount / 3;
            int keyboard = lostGamesCount / 6;
            int display = lostGamesCount / 12;



            double total =
                headset * headsetPrice +
                mouse * mousePrice +
                keyboard * keyboardPrice +
                display * displayPrice;




            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}

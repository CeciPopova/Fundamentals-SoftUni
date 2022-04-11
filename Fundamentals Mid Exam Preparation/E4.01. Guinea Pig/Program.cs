using System;

namespace MidExam01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            bool isFinished = false; 

            for (int i = 1; i <= 30; i++)
            {
                food -= 0.300;
                if (food<=0)
                {
                    isFinished = true;  
                    break;
                }
                if (i%2==0)
                {
                    hay -= 0.05 * food;
                    if (hay<=0)
                    {
                        isFinished=true;
                        break;
                    }
                }
                if (i%3==0)
                {
                    cover -= weight * 1 / 3;
                    if (cover <= 0)
                    {
                        isFinished = true;
                        break;
                    }
                }
            }
            if (isFinished)
            {
                Console.WriteLine( "Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
            }

        }
    }
}

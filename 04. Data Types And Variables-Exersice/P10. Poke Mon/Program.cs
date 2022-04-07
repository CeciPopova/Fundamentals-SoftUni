using System;

namespace P10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int originalValue =power;
            int countTargets = 0;
            while (power >= distanceBetweenTargets)
            {

                power -= distanceBetweenTargets;
                countTargets++;


                if (power ==(decimal)(originalValue * 0.50) && exhaustionFactor!=0)
                {
                  
                        power /= exhaustionFactor;
                    
                }
            }
            if (power < distanceBetweenTargets)
            {
                Console.WriteLine(power);
                Console.WriteLine(countTargets);
            }
        }
    }
}

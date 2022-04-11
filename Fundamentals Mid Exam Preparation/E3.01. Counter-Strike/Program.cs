using System;

namespace MidExam01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int energy=int.Parse(Console.ReadLine());
            
            string command = Console.ReadLine();
            int count=0;

            while (command != "End of battle")
            {
                int distanceOfEnemy = int.Parse(command);

                if (energy < distanceOfEnemy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    return;
                }
                energy -= distanceOfEnemy;
                count++;

                if (count % 3 == 0)
                {
                    energy += count;
                }


                command = Console.ReadLine();

            }
            
                Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
            
            
        }
    }
}

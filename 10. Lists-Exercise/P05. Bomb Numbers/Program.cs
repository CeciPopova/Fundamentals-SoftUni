using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            List<int> spesialNum = Console.ReadLine().Split()
                .Select(int.Parse).ToList();


            int bomb = spesialNum[0];
            int power = spesialNum[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];

                if (currNum==bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex>numbers.Count-1)
                    {
                        endIndex = numbers.Count - 1;

                    }
                    int endIndexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToRemove);
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}

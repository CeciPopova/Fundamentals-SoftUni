using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestLenght = 1;
            int bestStartIndex = 0;
            int bestSequenseSum = 0;
            int bestSequenceIndex = 0;
            int sequanseCounter = 0;
            int[] bestSequance = new int[n];

            string command = Console.ReadLine();
            while (command!="Clone them!")
            {
                int[] dnaSequence = command.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                sequanseCounter++;
                int lenght = 1;
                int bestCurrentLenght = 1;
                int startIndex = 0;
                int currentSequenseSum = 0;
                for (int i = 0; i < dnaSequence.Length-1; i++)
                {
                    if (dnaSequence[i]==dnaSequence[i+1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }
                    if (lenght>bestCurrentLenght)
                    {
                        bestCurrentLenght = lenght;
                        startIndex = i;
                    }
                    currentSequenseSum += dnaSequence[i];
                }
                currentSequenseSum += dnaSequence[n - 1];
                if (bestCurrentLenght>bestLenght)
                {
                    bestLenght = bestCurrentLenght;
                    bestStartIndex = startIndex;
                    bestSequenseSum = currentSequenseSum;
                    bestSequenceIndex = sequanseCounter;
                    bestSequance = dnaSequence.ToArray();
                }
                else if (bestCurrentLenght==bestLenght)
                {
                    if (startIndex<bestStartIndex)
                    {

                        bestLenght = bestCurrentLenght;
                        bestStartIndex = startIndex;
                        bestSequenseSum = currentSequenseSum;
                        bestSequenceIndex = sequanseCounter;
                        bestSequance = dnaSequence.ToArray();
                    }
                    else if (startIndex==bestStartIndex)
                    {
                        if (currentSequenseSum>bestSequenseSum)
                        {

                            bestLenght = bestCurrentLenght;
                            bestStartIndex = startIndex;
                            bestSequenseSum = currentSequenseSum;
                            bestSequenceIndex = sequanseCounter;
                            bestSequance = dnaSequence.ToArray();
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenseSum}.");
            Console.WriteLine(string.Join(" ",bestSequance));
        }
    }
}

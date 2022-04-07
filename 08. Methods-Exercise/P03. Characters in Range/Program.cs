using System;

namespace P03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            if (firstCh<secondCh)
            {
                PrintAllCharacters(firstCh, secondCh);
            }
            else
            {
                PrintAllCharacters(secondCh, firstCh);
            }
        }
        static void PrintAllCharacters( char start, char end)
        {
            if (start<end)
            {

                for (char i = start; i < end; i++)
                {
                    if (i != start)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {

                for (char i = end; i > start; i--)
                {
                    if (i != end)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}

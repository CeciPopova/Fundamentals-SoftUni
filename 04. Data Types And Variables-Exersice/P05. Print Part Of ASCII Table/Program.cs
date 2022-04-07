using System;

namespace P05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start=int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());

            for (int currIndex = start; currIndex <= end; currIndex++)
            {
                char character=(char)currIndex; 
                Console.Write(character + " ");   
                
            }
        }
    }
}

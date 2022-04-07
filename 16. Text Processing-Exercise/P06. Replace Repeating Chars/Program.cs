using System;

namespace P06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           
            for (int i = 0; i < text.Length; i++)
            {
                if (i<text.Length-1)
                {
                    char currChar = text[i];
                    char nextChar = text[i + 1];
                    if (currChar == nextChar)
                    {
                        text = text.Remove(i,1);
                        i--;
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}

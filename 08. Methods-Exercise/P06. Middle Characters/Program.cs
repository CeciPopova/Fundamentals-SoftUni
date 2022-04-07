using System;

namespace P06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            GetTheMiddleCharacters(text);
        }
        static void GetTheMiddleCharacters(string text)
        {
            int lenght = text.Length;    
            int middleChar = lenght / 2;


            if (text.Length%2==0)
            {
                Console.Write(text[middleChar-1]);

                Console.Write(text[middleChar]);

            }
            else
            {
                Console.WriteLine(text[middleChar]);
            }

            
        }
    }
}

using System;
using System.Collections.Generic;

namespace P04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();   
           
            char[] textChars = text.ToCharArray();
            for (int i = 0; i < textChars.Length; i++)
            {
                int currChar = (int)textChars[i]+3;
                char encriptedChar = (char)currChar;
                Console.Write(encriptedChar);  
            }
           
        } 
    }
}

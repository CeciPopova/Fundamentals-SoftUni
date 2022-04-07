using System;

namespace P09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number=Console.ReadLine();
            while (number!="END")
            {
                Console.WriteLine(CheckPalindrome(number));
                number = Console.ReadLine();
            }

        }
        static bool CheckPalindrome(string strOriginal)
        {
            string strReverse=string.Empty;

            int lenght = strOriginal.Length;

            for (int i = lenght-1; i >= 0; i--)
            {
                strReverse+=strOriginal[i]; 
            }
            return strReverse.Equals(strOriginal);  
        }
    }
}

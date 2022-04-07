using System;
using System.Linq;

namespace P01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string word = Console.ReadLine();

            while (word!="end")
            {
                char[] arrWord = word.ToCharArray();
                char[] reverseArr = arrWord.Reverse().ToArray();
                // Array.Reverse(arrWord);
                // string reverseWord = new string(arrWord);
                string reverseWord = new string(reverseArr);
                 Console.WriteLine($"{word} = {reverseWord}");




                word = Console.ReadLine();  
            }
          
        }
    }
}

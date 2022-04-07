using System;
using System.Text;
using System.Linq;

namespace P05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder letters=new StringBuilder();
            StringBuilder digits = new StringBuilder(); 
            StringBuilder otherChars = new StringBuilder();

            foreach (char item in text)
            {
                if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else if (char.IsDigit(item))
                {
                    digits.Append(item);    
                }
                else
                {
                    otherChars.Append(item);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}

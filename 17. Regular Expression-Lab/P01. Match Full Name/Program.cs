using System;
using System.Text.RegularExpressions;

namespace P01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern); 

            string names =Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names,pattern);  

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}

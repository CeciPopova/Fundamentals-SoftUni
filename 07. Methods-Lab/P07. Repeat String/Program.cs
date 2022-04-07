using System;
using System.Text;

namespace P07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str=Console.ReadLine();
            int count=int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(str,count));   
        }
        static string RepeatString(string str,int countOfRepeats)
        {
           StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < countOfRepeats; i++)
            {
                stringBuilder.Append(str);
            }
            return stringBuilder.ToString();
        }
    }
}

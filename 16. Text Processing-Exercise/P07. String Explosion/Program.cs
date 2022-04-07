using System;
using System.Text;

namespace P07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            StringBuilder sb = new StringBuilder();
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '>')
                {
                    sb.Append(c);   
                    power += int.Parse(input[i+1].ToString());

                }
                else
                {
                    if (power==0)
                    {
                        sb.Append(c);
                    }
                    else
                    {
                        power--;
                    }
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}

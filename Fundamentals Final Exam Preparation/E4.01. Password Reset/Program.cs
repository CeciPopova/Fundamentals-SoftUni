using System;
using System.Linq;

namespace E4._01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();   
            string command = Console.ReadLine();
            while (command!="Done")
            {
                string[] instruction = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = instruction[0];
                if (action == "TakeOdd")
                {
                    char[] oddChars = input.Where((x, index) => index % 2 != 0).ToArray();
                    input = string.Join("", oddChars);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(instruction[1]);
                    int length = int.Parse(instruction[2]);

                    string substring = input.Substring(index, length);
                    int firstIndex = input.IndexOf(substring);
                    input = input.Remove(firstIndex, substring.Length);
                }
                else if (action == "Substitute")
                {
                    string substring = instruction[1];
                    string substitute = instruction[2];
                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, substitute);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        command = Console.ReadLine();
                        continue;
                    }

                }
                Console.WriteLine(input);
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}

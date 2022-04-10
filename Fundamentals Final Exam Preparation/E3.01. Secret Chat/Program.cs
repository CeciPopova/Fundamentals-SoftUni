using System;
using System.Linq;

namespace E3._01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] instructions = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = instructions[0];
                if (action == "InsertSpace")
                {
                    int index = int.Parse(instructions[1]);
                    message = message.Insert(index, " ");
                }
                else if (action == "Reverse")
                {
                    string substring = instructions[1]; 
                    if (message.Contains(substring))
                    {
                        int startIndex = message.IndexOf(substring);
                        message = message.Remove(startIndex, substring.Length);
                        substring = string.Join("", substring.Reverse());
                        message = message + substring;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine();
                        continue;
                    }

                }
                else if (action == "ChangeAll")
                {
                    string substring = instructions[1];
                    string replacement = instructions[2];   
                    message = message.Replace(substring, replacement);
                }
                Console.WriteLine(message);

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}

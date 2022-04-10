using System;
using System.Linq;

namespace E5._01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] instructions = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = instructions[0];
                if (action== "Contains")
                {
                    string substring = instructions[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");

                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action=="Flip")
                {
                    string typeOfLetters = instructions[1];
                    int startIndex = int.Parse(instructions[2]);
                    int endIndex = int.Parse(instructions[3]); 
                    string substring = activationKey.Substring(startIndex,endIndex-startIndex);
                    string newSubstring = string.Empty;
                    if (typeOfLetters == "Upper")
                    {
                        newSubstring = substring.ToUpper();
                    }
                    else if (typeOfLetters == "Lower")
                    {
                        newSubstring = substring.ToLower();
                    }
                    activationKey = activationKey.Replace(substring, newSubstring);
                    Console.WriteLine(activationKey);

                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endIndex = int.Parse(instructions[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}

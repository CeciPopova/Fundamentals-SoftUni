using System;
using System.Linq;

namespace P01._Decrypting_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  
            string command = Console.ReadLine();
            while (command!="Finish")
            {
                string[] commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();  
                string action = commandArgs[0];
                if (action=="Replace")
                {
                    string currChar = commandArgs[1];
                    string newChar = commandArgs[2];
                    if (input.Contains(currChar))
                    {
                        input = input.Replace(currChar, newChar);
                        Console.WriteLine(input);
                    }
                }
                else if (action=="Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    if (startIndex>=0 && startIndex<input.Length && endIndex>=0 && endIndex<input.Length)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }
                else if (action=="Make")
                {
                    string type = commandArgs[1];   
                    if (type=="Upper")
                    {
                        input=input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else if (type=="Lower")
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }

                }
                else if (action=="Check")
                {
                    string substring = commandArgs[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }

                }
                else if (action=="Sum")
                {
                    int startIndex =int.Parse(commandArgs[1]);  
                    int endIndex =int.Parse(commandArgs[2]);
                    if (startIndex>=0 && startIndex<input.Length && endIndex>=0 && endIndex<input.Length)
                    {
                        int sum = 0;
                        string substring = input.Substring(startIndex, endIndex - startIndex + 1);
                        for (int i = 0; i < substring.Length; i++)
                        {
                            int currChar =(int)substring[i];
                            sum += currChar;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }


                command = Console.ReadLine();   
            }
        }
    }
}

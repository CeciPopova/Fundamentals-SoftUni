using System;
using System.Linq;

namespace E1._01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string encriptedMessage = Console.ReadLine();

            string instructions = Console.ReadLine();
            while (instructions!= "Decode")
            {
                string[] instructionArgs = instructions.Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray(); 
                string action = instructionArgs[0];
                if (action=="Move")
                {
                    int numOfLetters = int.Parse(instructionArgs[1]);

                    string lettersToMove = encriptedMessage.Substring(0, numOfLetters); 
                    encriptedMessage = encriptedMessage.Remove(0,numOfLetters);
                    encriptedMessage = encriptedMessage + lettersToMove;
                }
                else if (action=="Insert")
                {
                    int index=int.Parse(instructionArgs[1]);
                    string value = instructionArgs[2];
                    if (index>=0 && index<=encriptedMessage.Length)
                    {
                        encriptedMessage = encriptedMessage.Insert(index, value);

                    }

                }
                else if (action=="ChangeAll")
                {
                    string substring = instructionArgs[1];  
                    string replasement = instructionArgs[2];
                    if (encriptedMessage.Contains(substring))
                    {
                        encriptedMessage = encriptedMessage.Replace(substring, replasement);

                    }
                }

                instructions = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {encriptedMessage}");
        }
    }
}

using System;
using System.Linq;

namespace E2._01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopsList = Console.ReadLine();
            string command = Console.ReadLine();
            while (command!="Travel")
            {
                string[] cmdArgs = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = cmdArgs[0];
                if (action=="Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string stringToAdd = cmdArgs[2];
                    if (index>=0 && index<stopsList.Length)
                    {
                      stopsList = stopsList.Insert(index, stringToAdd);
                    }
                }
                else if (action=="Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    if (startIndex>=0 && startIndex<stopsList.Length && endIndex>=0 && endIndex<stopsList.Length)
                    {
                        stopsList = stopsList.Remove(startIndex, endIndex - startIndex+1);
                    }
                }
                else if (action=="Switch")
                {
                    string oldstring = cmdArgs[1];
                    string newstring = cmdArgs[2];
                    if (stopsList.Contains(oldstring))
                    {
                        stopsList = stopsList.Replace(oldstring, newstring);

                    }
                }
                Console.WriteLine(stopsList);

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stopsList}");
        }
    }
}

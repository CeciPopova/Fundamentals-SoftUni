using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsList = Console.ReadLine().Split(", ").ToList();

            int blacklistedNamesCount = 0;
            int lostNamesCount = 0;
            string command = Console.ReadLine();
            while (command != "Report")
            {
                string[] arr = command.Split().ToArray();
                string action = arr[0];

                if (action == "Blacklist")
                {
                    string name = arr[1];
                    if (friendsList.Contains(name))
                    {
                        for (int i = 0; i < friendsList.Count; i++)
                        {
                            string blacklisted = "Blacklisted";
                            
                            if (friendsList[i]==name)
                            {
                                friendsList.RemoveAt(i);
                                friendsList.Insert(i, blacklisted);
                                blacklistedNamesCount++;
                                Console.WriteLine($"{name} was blacklisted.");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                        command = Console.ReadLine();
                        continue;
                    }

                }
                else if (action == "Error")
                {
                    int index = int.Parse(arr[1]);
                    if (index >= 0 && index < friendsList.Count)
                    {
                        for (int i = 0; i < friendsList.Count; i++)
                        {
                            string lost = "Lost";
                            string name = friendsList[i];
                            if (i == index && name!="Blacklisted" && name!= lost)
                            {
                                friendsList.RemoveAt(i);
                                friendsList.Insert(i, lost);
                                lostNamesCount++;
                                Console.WriteLine($"{name} was lost due to an error.");
                            }
                        }

                    }

                }
                else if (action == "Change")
                {
                    int index = int.Parse(arr[1]);
                    string newName = arr[2];
                    if (index >= 0 && index < friendsList.Count)
                    {
                        for (int i = 0; i < friendsList.Count; i++)
                        {
                            if (i == index)
                            {
                                string name = friendsList[i];
                                friendsList.RemoveAt(index);
                                friendsList.Insert(index, newName);
                                Console.WriteLine($"{name} changed his username to {newName}.");
                            }
                        }
                    }

                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", friendsList));
        }
    }
}

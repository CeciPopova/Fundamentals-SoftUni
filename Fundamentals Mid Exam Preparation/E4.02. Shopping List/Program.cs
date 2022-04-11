
using System;
using System.Collections.Generic;
using System.Linq;


namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                
                string[] arr = command.Split().ToArray();
                string action=arr[0];   

                if (action == "Urgent")
                {
                    if (!shoppingList.Contains(arr[1]))
                    {
                        shoppingList.Insert(0, arr[1]);
                    }
                }

                if (action == "Unnecessary")
                {
                    if (shoppingList.Contains(arr[1]))
                    {
                        shoppingList.Remove(arr[1]);
                    }
                }

                if (action == "Correct")
                {
                    string oldItem = arr[1];
                    string newItem = arr[2];

                    int index = 0;

                    if (shoppingList.Contains(arr[1]))
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            if (shoppingList[i] == oldItem)
                            {
                                index = i;
                            }
                        }

                        shoppingList.Remove(oldItem);
                        shoppingList.Insert(index, newItem);
                    }
                }

                if (action == "Rearrange")
                {
                    if (shoppingList.Contains(arr[1]))
                    {
                        string reaarange = arr[1];

                        shoppingList.Remove(arr[1]);
                        shoppingList.Add(reaarange);
                    }
                }
                command=Console.ReadLine(); 
            }

            Console.WriteLine(string.Join(", ",shoppingList));
        }
    }
}
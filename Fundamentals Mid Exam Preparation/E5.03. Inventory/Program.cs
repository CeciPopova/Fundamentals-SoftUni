using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while (command!="Craft!")
            {
                string[] arr = command.Split(" - ").ToArray();
                string action = arr[0];
                string item = arr[1];   

                if (action=="Collect")
                {
                    
                    if (!items.Contains(item))
                    {
                        items.Add(item);    
                    }
                }
                else if (action=="Drop")
                {
                    
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (action=="Combine Items")
                {
                    string[] oldNew=item.Split(":").ToArray();
                    string oldItem = oldNew[0];
                    string newItem = oldNew[1];
                    if (items.Contains(oldItem))
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i]==oldItem)
                            {
                                items.Insert(i + 1, newItem);
                            }
                        }
                    }
                }
                else if (action=="Renew")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ",items));
        }
    }
}

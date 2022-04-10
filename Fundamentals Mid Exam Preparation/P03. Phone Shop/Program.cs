using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfPhones = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] arr= command.Split(" - ");
                string action=arr[0];
                if (action=="Add")
                {
                    string phone=arr[1];
                    if (!listOfPhones.Contains(phone))
                    {
                        listOfPhones.Add(phone);
                    }

                }
                else if (action=="Remove")
                {
                    string phone= arr[1];
                    if (listOfPhones.Contains(phone))
                    {
                        listOfPhones.Remove(phone);
                    }

                }
                else if (action=="Bonus phone")
                {
                    string oldNew = arr[1];
                    string[] oldNewPhones = oldNew.Split(":");
                    string newPhone = oldNewPhones[1];
                    string oldPhone = oldNewPhones[0];

                    if (listOfPhones.Contains(oldPhone))
                    {
                        for (int i = 0; i < listOfPhones.Count; i++)
                        {
                            if (listOfPhones[i]==oldPhone)
                            {
                                listOfPhones.Insert(i + 1, newPhone);
                            }
                        }
                    }
                }
                else if (action=="Last")
                {
                    string phone = arr[1];
                    if (listOfPhones.Contains(phone))
                    {
                        listOfPhones.Remove(phone);
                        listOfPhones.Add(phone);
                    }

                }
                

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", listOfPhones));
        }
    }
}

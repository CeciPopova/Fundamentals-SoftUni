using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tresureChest = Console.ReadLine().Split('|').ToList();
          
            string command=Console.ReadLine();

            while (command!="Yohoho!")
            {
                string[] arr = command.Split().ToArray();
                string action=arr[0];

                if (action=="Loot")
                {
                    for (int i = 1; i < arr.Length; i++)
                    {
                        string item=arr[i]; 
                        if (!tresureChest.Contains(item))
                        {
                            tresureChest.Insert(0, item);   
                        }
                    }
                }
                else if (action=="Drop")
                {
                    int index=int.Parse(arr[1]);
                    
                    if (index>=0 && index<tresureChest.Count)
                    {
                        string item = tresureChest[index];
                        tresureChest.RemoveAt(index);   
                        tresureChest.Add(item);
                    }
                    else
                    {
                        command=Console.ReadLine();
                        continue;
                    }

                }
                else if (action=="Steal")
                {
                    int count = int.Parse(arr[1]);
                    if (count>tresureChest.Count)
                    {
                        count = tresureChest.Count;
                    }
                    List<string> result = new List<string>();

                    if (count > 0 && count <= tresureChest.Count)
                    {
                        int indexToRemove = tresureChest.Count - count;
                        for (int i = indexToRemove; i < tresureChest.Count; i++)
                        {
                            string item = tresureChest[i];
                            result.Add(item);
                        }

                        tresureChest.RemoveRange(indexToRemove, count);
                        Console.WriteLine(string.Join(", ", result));
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    
                }
                

                command = Console.ReadLine();
            }
           

            if (tresureChest.Count >0)
            {
                decimal sumCredit = 0;
                for (int i = 0; i < tresureChest.Count; i++)
                {
                    string item = tresureChest[i];
                   decimal lenght = item.Length;
                    sumCredit += lenght;
                }
                decimal pirateCredit = sumCredit / tresureChest.Count;
                Console.WriteLine($"Average treasure gain: {pirateCredit:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}

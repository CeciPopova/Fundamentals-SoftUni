using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne" },
                { "fragments", "Valanyr" },
                { "motes", "Dragonwrath" }

            };

            Dictionary<string, int> junk = new Dictionary<string, int>();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
               {"shards",0},
               { "motes",0},
               {"fragments",0}
               
            };
            string itemObtained = string.Empty;
           
            while (String.IsNullOrEmpty(itemObtained))
            {
                string input = Console.ReadLine().ToLower();
                string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < arr.Length; i+=2)
                {
                    string currMaterial = arr[i+1];
                    int currQuantity = int.Parse(arr[i]);

                    if (keyMaterials.ContainsKey(currMaterial))
                    {

                        keyMaterials[currMaterial]+=currQuantity;

                        if (keyMaterials[currMaterial]>=250)
                        {
                            itemObtained = craftingTable[currMaterial];

                            keyMaterials[currMaterial] -= 250;
                            Console.WriteLine($"{itemObtained} obtained! ");
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currMaterial))
                        {
                            junk.Add(currMaterial, 0);
                           
                        }
                        junk[currMaterial] += currQuantity;
                    }
                }


            }
            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");  
            }

        }

    }
}

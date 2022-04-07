using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        class Item
        {
            public Item(string name,double price)
            {
                this.Name = name;
                this.Price = price; 
            }
            public string Name { get; set; }
            public double Price  { get; set; } 
        }
        class Box
        {
            public Box(string serialNum,Item item,int itemQuantity,double boxPrice)
            {
                this.SerialNumber = serialNum;
                this.Item = item;
                this.ItemQuantity = itemQuantity;   
                this.BoxPrice = boxPrice;   
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double BoxPrice { get; set; }
        }
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            List<Box> boxes = new List<Box>();  

            while (command!="end")
            {
                string[] data = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string serialNum = data[0]; 
                string itemName = data[1];
                int itemQuantity=int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                Item item = new Item(itemName,itemPrice);
                double boxPrice = itemQuantity * itemPrice;
                Box box=new Box(serialNum,item,itemQuantity,boxPrice);  
                
                   boxes.Add(box);
                command = Console.ReadLine();
            }
            boxes=boxes.OrderByDescending(x => x.BoxPrice).ToList();
            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }
}

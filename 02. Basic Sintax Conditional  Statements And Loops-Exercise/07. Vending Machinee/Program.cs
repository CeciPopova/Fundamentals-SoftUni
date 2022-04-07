using System;

namespace _07._Vending_Machinee
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string coins=Console.ReadLine();
            double money = 0;
            double sum = 0;
            while (coins!="Start")
            {
                
                 money=double.Parse(coins);
                if (money==0.1||money==0.2||money==0.5||money==1||money==2)
                {
                    sum +=money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                    continue;
                }

                coins=Console.ReadLine();
            }
            string input = string.Empty;  
            while (input!="End")
            { 
                input = Console.ReadLine(); 
                if (input=="End")
                {
                    break;
                }
            
                if (input=="Nuts")
                {
                    if (sum>=2.0)
                    {
                        Console.WriteLine("Purchased nuts");
                       sum-= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input=="Water")
                {
                    if (sum>=0.7)
                    {
                        Console.WriteLine("Purchased water");
                       sum -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                } 
                else if (input=="Crisps")
                {
                    if (sum>=1.5)
                    {
                        Console.WriteLine("Purchased crisps");
                        sum -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                } 
                else if (input=="Soda")
                {
                    if (sum>=0.8)
                    {
                        Console.WriteLine("Purchased soda");
                        sum -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                } 
              
                 else if (input=="Coke")
                 { 
                    if (sum>=1.0)
                    {
                        Console.WriteLine("Purchased coke");
                       sum-=1.0; 
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                 }
                else
                {
                    Console.WriteLine("Invalid product");
                }


               
            }

            if (input=="End")
            {
                Console.WriteLine($"Change: {sum:f2}");
            }
             
        }
    }
}

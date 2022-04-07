using System;

namespace P09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startFlow = int.Parse(Console.ReadLine());

            int countOfDays = 0;
            int leftFlow = 0;
            while (startFlow >= 100)
            {

                countOfDays++;
                if (countOfDays == 1)
                {
                    leftFlow = startFlow - 26;
                }
                else
                {
                    leftFlow += startFlow - 26;
                }
            
            startFlow -= 10;
        }
                if (leftFlow>=26)
                {
                    leftFlow -= 26;
                }
                else
                {
                    leftFlow = 0;
                }
                
            
            Console.WriteLine(countOfDays);
            Console.WriteLine(leftFlow);
            }
        }
    }

   
            
        
    


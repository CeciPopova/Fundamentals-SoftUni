using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_Exam03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elemens = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            
            
            
            int count=0;    
            while (command!="end")
            {
                count++;
                string[] arr = command.Split().ToArray();
                int firsIndex=int.Parse(arr[0]);  
                int secondIndex=int.Parse(arr[1]);


                if (firsIndex == secondIndex || firsIndex < 0 || firsIndex >= elemens.Count || secondIndex < 0 || secondIndex >= elemens.Count)
                {
                    string newElement = ($"-{count}a");
                    elemens.Insert((elemens.Count / 2), newElement);
                    elemens.Insert((elemens.Count / 2), newElement);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {


                    string firstElement = elemens[firsIndex];
                    string secondElement = elemens[secondIndex];
                    if (firstElement == secondElement)
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elemens[firsIndex]}!");

                        elemens.RemoveAll(x => x == firstElement);
                    }
                    else if (firstElement != secondElement)
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                if (elemens.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ",elemens));
        } 
    }
}
 
using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> firstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();  
           List<int> secondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            while (firstPlayer.Count!=0 && secondPlayer.Count!=0)
            {
                int firstPlayerCard=firstPlayer[0]; 
                int secondPlayerCard=secondPlayer[0];
                if (firstPlayerCard>secondPlayerCard)
                {
                    firstPlayer.Add(secondPlayerCard);
                    firstPlayer.Add(firstPlayerCard);
                }
                else if (secondPlayerCard>firstPlayerCard)
                {
                    secondPlayer.Add(firstPlayerCard);  
                    secondPlayer.Add(secondPlayerCard); 
                }
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);   
            }
            if (firstPlayer.Count==0)
            {
                int sum=secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                int sum=firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }

        }
    }
}

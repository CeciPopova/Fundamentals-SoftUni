using System;
using System.Linq;

namespace Mid_Exam02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weitingPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] result = new int[wagons.Length];

            for (int i = 0; i < wagons.Length; i++)
            {
                int currWagon = wagons[i];
                if (weitingPeople > 0)
                {
                    

                    while (currWagon < 4 && weitingPeople > 0)
                    {
                        weitingPeople--;
                        currWagon++;
                    }

                    result[i] = currWagon;
                }
                else
                {
                    result[i] = currWagon;
                    
                }

            }

            bool isFull=false; 
           
            
                for (int i = 0; i < result.Length; i++)
                {
                int wagon=result[i];    
                    if (wagon==4)
                    {
                        isFull = true;
                    }
                    else
                    {
                        isFull=false;
                    }
                }
            
            if (weitingPeople > 0 )
            {
                Console.WriteLine($"There isn't enough space! {weitingPeople} people in a queue!");
                
            }
            else if (weitingPeople <= 0 && isFull==false)
            {
                Console.WriteLine("The lift has empty spots!");
                
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}

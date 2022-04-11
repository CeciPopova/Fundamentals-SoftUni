using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();   

            string command=Console.ReadLine();
            int count = 0;
            while (command!="End")
            {
                int index= int.Parse(command);


                if (index>=0&&index<targets.Count)
                {
                    int currTarget= targets[index];
                    if (currTarget==-1)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                   
                    targets[index] = -1;
                    count++;
                    for (int i = 0; i < targets.Count; i++)
                    {
                        
                        int target = targets[i];
                        if (i!=index && target!=-1)
                        {
                            if (target>currTarget)
                            {
                                targets[i] -= currTarget;
                            }
                            else
                            {
                                targets[i] += currTarget;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.Write($"Shot targets: {count} -> ");
            Console.WriteLine(string.Join(" ",targets));
        }
    }
}

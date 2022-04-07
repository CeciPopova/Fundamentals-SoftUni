using System;
using System.Collections.Generic;

namespace P02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,int> resurses = new Dictionary<string,int>();

            string resurce=Console.ReadLine();
            while (resurce!="stop")
            {
                int quantity=int.Parse(Console.ReadLine());

                if (resurses.ContainsKey(resurce))
                {
                    resurses[resurce] += quantity;
                }
                else
                {
                    resurses.Add(resurce, quantity);
                }
                

                resurce=Console.ReadLine();
            }
            foreach (var rqp in resurses)
            {
                Console.WriteLine($"{rqp.Key} -> {rqp.Value}");
            }
        }
    }
}

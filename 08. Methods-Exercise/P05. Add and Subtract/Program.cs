using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first=int.Parse(Console.ReadLine());    
            int second=int.Parse(Console.ReadLine());    
            int third=int.Parse(Console.ReadLine());
            int result = GetTheSumOfTwoInt(first, second) - third;
            Console.WriteLine(result);  
        }
        static int GetTheSumOfTwoInt(int first,int second)
        {
            int sum = first + second;
            return sum; 
        }
       
        
    }
}

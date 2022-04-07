using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
         
           int[] arr1=new int[n];   
            int[] arr2=new int[n];

            for (int i = 0; i < n; i++)
            {
           int[] nums=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  
                
                int firstNum=nums[0];   
                int secondNum=nums[1];  

                if (i%2==0)
                {
                    arr1[i] = firstNum;  
                    arr2[i] = secondNum;
                }
                else
                {
                    arr2[i]=firstNum;    
                    arr1[i]=secondNum;
                }
            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ",arr2));
        }
    }
}

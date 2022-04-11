using System;
using System.Linq;

namespace Mid_Exam02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            

            while (command != "end")
            {
                string[] arr = command.Split();
                string action = arr[0];

                if (action == "swap")
                {
                    int index1 = int.Parse(arr[1]);
                    int index2 = int.Parse(arr[2]);
                    int firstNum=numbers[index1];
                    int secondNum=numbers[index2];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i == index1)
                        {
                            numbers[i] = secondNum;
                        }
                        else if (i == index2)
                        {
                            numbers[i] = firstNum;
                        }
                        else
                        {
                            numbers[i] = numbers[i];
                        }
                    }
                  
                }
                else if (action == "multiply")
                {
                    int index1 = int.Parse(arr[1]);
                    int index2 = int.Parse(arr[2]);
                    int firstNum = numbers[index1];
                    int secondNum = numbers[index2];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i == index1)
                        {
                           numbers[i] = firstNum * secondNum;
                        }
                        else
                        {
                            numbers[i] = numbers[i];
                        }
                    }
                    
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int currNum = numbers[i];
                        numbers[i] = currNum - 1;

                    }
                }
                    command = Console.ReadLine();

               
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}

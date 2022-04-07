using System;

namespace P03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople=int.Parse(Console.ReadLine());
            int capacity=int.Parse(Console.ReadLine());

            int countOfCourses = 0;
            if (numOfPeople%capacity==0)
            {
                countOfCourses = numOfPeople / capacity;
            }
            else
            {
                countOfCourses=numOfPeople/capacity+1;    
            }
            Console.WriteLine(countOfCourses);
        }
    }
}

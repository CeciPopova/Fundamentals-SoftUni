using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            

            string password = string.Empty;
            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }

            string command = Console.ReadLine();
            int count = 0;
            while (command!=password)
            {
                count ++;
                if (count>3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                
                Console.WriteLine("Incorrect password. Try again.");
                command = Console.ReadLine();
            }
            if (command==password)
            {

                Console.WriteLine($"User {username} logged in.");
            }
            

            
            
        }
    }
}

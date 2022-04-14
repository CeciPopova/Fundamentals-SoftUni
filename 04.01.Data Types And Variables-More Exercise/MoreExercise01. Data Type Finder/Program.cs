using System;

namespace MoreExercise01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command!="END")
            {
                bool isIntInput=int.TryParse(command, out int intValue);
                bool isDoubleInput = double.TryParse(command, out double doubleValue);
                bool isCharInput = char.TryParse(command, out char charValue);
                bool isBoolInput = bool.TryParse(command, out bool boolValue);

                if (isIntInput)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (isDoubleInput)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (isCharInput)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (isBoolInput)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }   


                command = Console.ReadLine();
            }
        }
    }
}

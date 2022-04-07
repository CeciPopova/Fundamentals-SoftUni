using System;

namespace P03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = Console.ReadLine();
            int lastIndex = pathToFile.LastIndexOf('\\');
            string nameAndExtension = pathToFile.Substring(lastIndex + 1);  
            int dotIndex = nameAndExtension.LastIndexOf('.');   
            string extension = nameAndExtension.Substring(dotIndex + 1);
            string fileName = nameAndExtension.Remove(dotIndex);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}

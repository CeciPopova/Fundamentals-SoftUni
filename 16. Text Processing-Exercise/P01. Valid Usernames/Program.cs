using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (Validation(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        static bool Validation(string username)
        {
            bool isValid = false;
            if (username.Length >= 3 && username.Length <= 16)
            {
                char[] chars = username.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    char currChar = chars[i];
                    if (char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }
    }
}

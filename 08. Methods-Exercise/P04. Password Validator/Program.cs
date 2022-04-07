using System;

namespace P04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minCountChar = 6;
            const int maxCountChar = 10;
            const int minDigitCount = 2;

            string password=Console.ReadLine();
            ValidatePassword(password,minCountChar,maxCountChar,minDigitCount);

        }
        static void ValidatePassword(string password,int minCountChar ,int maxCountChar ,int minDigitCount)
        { 
            bool isValid=true; 
            if (!ValidatePassworLenght(password,minCountChar,maxCountChar))
            {
                isValid = false;
                Console.WriteLine($"Password must be between {minCountChar} and {maxCountChar} characters");
            }
            if (!ValidatePasswordAlfaNumerical(password))
            {
                isValid = false;
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            if (!ValidatePasswordDigitMinCount(password,minDigitCount))
            {
                isValid = false;
                Console.WriteLine($"Password must have at least 2 digits");
            }
            if(isValid)
            {    
                Console.WriteLine("Password is valid");
            }
        }
        static bool ValidatePassworLenght(string password,int minCountChar, int maxCountChars)
        {
            if (password.Length>=minCountChar&&password.Length<=maxCountChars)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static bool ValidatePasswordAlfaNumerical(string password)
        {
            bool result = false;    
            foreach (char ch in password)
            {
                if (Char.IsLetterOrDigit(ch))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
                
            }
            return result;
        }
        static bool ValidatePasswordDigitMinCount(string password , int minDigitCount)
        {
            int count = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    count++;
                }
            }
            if (count>=minDigitCount)
            {
                return true;
            }
            else
            {
                return false ;
            }
        }
    }
}

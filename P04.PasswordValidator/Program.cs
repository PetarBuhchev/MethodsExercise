using System;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] pswd = password.ToCharArray(); 
            Validator(pswd);
        }
        static void Validator(char[] pswd) 
        {
            int characters = pswd.Length;
            int digits = 0;
            int symbol = 0;

            for (int i = 0; i < characters; i++)
            {
                char c = pswd[i];
                int ascii = (int)c;
                if (ascii >= 48 && ascii <= 57)
                {
                    digits++;
                }
                else if (ascii >= 0 && ascii <= 64 || ascii >= 91 && ascii <= 96 || ascii >= 123 && ascii <= 127)
                {
                    symbol++;
                }
                
            }
            if (6 >= characters || characters >= 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (symbol>0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (characters >= 6 && characters <= 10 && symbol == 0 && digits >= 2) 
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

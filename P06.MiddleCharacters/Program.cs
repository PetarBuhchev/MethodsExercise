using System;

namespace P06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            if (length % 2 == 1) 
            {
                char[] chars = input.ToCharArray();
                Console.WriteLine(chars[length/2]);
            }
            else
            {
                char[] chars = input.ToCharArray();
                Console.WriteLine($"{chars[length/2-1]}{chars[(length/2)]}");
            }
        }
    }
}

using System;

namespace P02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Vowel(input.ToLower());
        }
        static void Vowel(string input)
        {
            int vowels = 0;
            for (int i = 0; i < input.Length; i++) 
            {
                char c = input[i];
                if (c == 'a' || c == 'o' || c == 'i' || c == 'e' || c == 'u')
                {
                    vowels++;
                }
            }
            Console.WriteLine(vowels);
        }
    }
}

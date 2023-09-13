using System;
using System.Linq;

namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {

                Console.WriteLine(Check(input));
            }
        }
        static string Check(string input)
        {
            int[] arrayInput = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arrayInput[i] = int.Parse(input[i].ToString());
            }

            int[] reverseInput = new int[arrayInput.Length];
            Array.Copy(arrayInput, reverseInput, arrayInput.Length);
            int error = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (arrayInput[i] == reverseInput[arrayInput.Length-1-i])
                {
                    continue;
                }
                else
                {
                    error++;
                }
            }
            if (error == 0) 
            {
                return "true";
            }
            else { return "false"; }
        }
    }
}

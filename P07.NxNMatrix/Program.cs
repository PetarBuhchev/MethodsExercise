using System;

namespace P07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            NxN(input);
        }
        static void NxN(int input)
        {
            for (int columns = 0; columns < input;columns++) 
            {
                for(int row = 0; row < input;row++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

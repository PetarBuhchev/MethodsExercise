using System;
using System.ComponentModel.DataAnnotations;

namespace P03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            Characters(symbol1, symbol2);
        }
        static void Characters(char symbol1, char symbol2) 
        {
            if (symbol1 < symbol2) 
            {
                for (char c = symbol1; c <= symbol2; c++)
                {
                    if (c == symbol1 || c == symbol2)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(c + " ");
                    }
                }
            }
            else
            {
                char temp = symbol1;
                symbol1 = symbol2;
                symbol2 = temp;
                for (char c = symbol1; c <= symbol2; c++) 
                {
                    if (c == symbol1 || c == symbol2)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(c + " ");
                    }
                }
            }
        }
    }
}

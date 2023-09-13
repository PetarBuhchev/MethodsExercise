using System;

namespace P05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Sum(num1, num2, num3);
        }
        static void Sum(int num1, int num2, int num3) 
        {
            int sum = num1+ num2;
            Subtract(sum, num3);
        }
        static void Subtract(int sum, int num3)
        {
            int subtract = sum - num3;
            Console.WriteLine(subtract);
        }
    }
}

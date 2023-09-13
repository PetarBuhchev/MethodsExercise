using System;

namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double division = Factorial(num1) / Factorial(num2);
            Console.WriteLine($"{division:f2}");
        }
        static double Factorial(int num)
        {
            double sum = 1;
            for (int i = 0; i < num; i++) 
            {
                sum = sum * (num - i);
            }
            return sum;
        }
    }
}

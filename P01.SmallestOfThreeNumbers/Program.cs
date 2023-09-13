using System;

namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Smallest(num1,num2, num3);
        }
        static void Smallest(int num1, int num2, int num3) 
        {
            if (num1 < num2 && num1 < num3) 
            {
                Console.WriteLine(num1);
            }
            else if (num1 > num2 && num2 < num3) 
            {
                Console.WriteLine(num2);
            }
            else { Console.WriteLine(num3); }
        }
    }
}

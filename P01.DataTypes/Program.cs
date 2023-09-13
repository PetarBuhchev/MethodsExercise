using System;

namespace P01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                Console.WriteLine(IntMethod());
            }
            else if (type == "real") 
            {
                Console.WriteLine(RealMethod());
            }
            else if (type == "string")
            {
                Console.WriteLine(StringMethod());
            }
        }
        static int IntMethod() 
        {
            int num = int.Parse(Console.ReadLine());
            return num * 2;
        }
        static string RealMethod() 
        {
            double num = double.Parse(Console.ReadLine());
            return $"{num * 1.5:f2}";
        }
        static string StringMethod()
        {
            string input = Console.ReadLine();
            return $"${input}$";
        }
    }
}

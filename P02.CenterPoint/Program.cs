using System;

namespace P02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            CoordinateSystem(x1,y1,x2,y2);
        }
        static void CoordinateSystem(int x1,int y1, int x2, int y2)
        {
            if (x1 < x2 &&  y1 < y2) 
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            if (x1 > x2 && y1 > y2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            if (x1 > x2 && y1 < y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            if (x1 < x2 && y1 > y2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}

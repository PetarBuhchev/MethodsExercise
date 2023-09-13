using System;
using System.Linq;

namespace P10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            Nums(endNumber);
        }

        static void Nums(int endNumber)
        {
            for (int i = 1; i <= endNumber; i++)
            {
                int[] arrayI = i.ToString().Select(c => int.Parse(c.ToString())).ToArray();
                int sum = 0;
                for (int j = 0; j < arrayI.Length; j++)
                {
                    sum += arrayI[j];
                }
                if (sum % 8 == 0)
                {                    
                    int odds = 0;
                    for (int m = 0; m < arrayI.Length; m++)
                    {
                        if (arrayI[m] == 1 || arrayI[m] == 3 || arrayI[m] == 5 || arrayI[m] == 7 || arrayI[m] == 9)
                        {
                            odds++;
                        }
                    }
                    if (odds >= 1)
                    {
                        Console.WriteLine(string.Join("", arrayI));
                    }
                }
            }
        }
    }
}

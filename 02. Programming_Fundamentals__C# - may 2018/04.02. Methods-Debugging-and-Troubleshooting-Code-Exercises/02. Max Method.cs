using System;

namespace ChooseADrink_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMax(a, b, c);
        }

        static void GetMax(int a, int b, int c)
        {
            int max = 0;
            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (a <= b && b >= c)
            {
                max = b;
            }
            else if (c >= a && c >= b)
            {
                max = c;
            }

            Console.WriteLine(max);
        }
    }
}
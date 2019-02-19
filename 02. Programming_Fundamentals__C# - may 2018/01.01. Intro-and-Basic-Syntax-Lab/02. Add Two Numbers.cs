using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        }
    }
}
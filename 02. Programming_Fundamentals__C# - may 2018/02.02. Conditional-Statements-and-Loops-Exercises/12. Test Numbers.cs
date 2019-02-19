using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;

            for (int i = num1; i >= 1; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    sum = sum + (3 * (i * j));
                    count++;

                    if (sum >= num3)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {num3}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                for (var i = num1; i <= num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (var i = num2; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int count = 0;
            string result = "";
            bool isFound = false;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    count++;
                    if ((i + j) == magic)
                    {
                        isFound = true;
                        result = $"{i} + {j}";
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Number found! {result} = {magic}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
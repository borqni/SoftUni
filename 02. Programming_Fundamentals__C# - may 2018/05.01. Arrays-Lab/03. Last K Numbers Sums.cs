using System;
namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            numbers[0] = 1;

            SumLastKNumbers(numbers, k);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void SumLastKNumbers(long[] numbers, int k)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int startIndex = Math.Max(0, i - k);
                long sum = 0;

                for (int j = startIndex; j <= i; j++)
                {
                    sum += numbers[j];
                }

                numbers[i] = sum;
            }
        }
    }
}
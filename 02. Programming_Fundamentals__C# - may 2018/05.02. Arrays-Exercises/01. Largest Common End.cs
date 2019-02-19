using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            int minLenght = Math.Min(firstInput.Length, secondInput.Length);
            int counterLeft = 0;
            int counterRight = 0;

            for (int i = 0; i < minLenght; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    counterLeft++;
                }

                if (firstInput[firstInput.Length - 1 - i] == secondInput[secondInput.Length - 1 - i])
                {
                    counterRight++;
                }
            }

            Console.WriteLine(Math.Max(counterLeft, counterRight));
        }
    }
}
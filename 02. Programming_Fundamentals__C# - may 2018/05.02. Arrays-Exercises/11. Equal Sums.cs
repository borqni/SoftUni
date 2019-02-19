using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (inputArr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int output = 0;
            bool isValid = false;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += inputArr[j];
                }

                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    rightSum += inputArr[j];
                }

                if (leftSum == rightSum)
                {
                    isValid = true;
                    Console.WriteLine(i);
                    break;
                }

            }

            if (isValid == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
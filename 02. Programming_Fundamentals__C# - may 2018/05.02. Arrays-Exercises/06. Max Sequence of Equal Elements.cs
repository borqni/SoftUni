using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int digit = 0;
            int max = 1;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int longest = 0;
                int curentIndex = inputArr[i];

                for (int j = i; j < inputArr.Length; j++)
                {
                    if (curentIndex == inputArr[j])
                    {
                        longest++;
                        if (max < longest)
                        {
                            max = longest;
                            digit = curentIndex;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write(digit + " ");
            }
        }
    }
}
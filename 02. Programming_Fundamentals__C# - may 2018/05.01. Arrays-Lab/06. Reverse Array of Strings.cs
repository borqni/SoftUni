using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i] + " ");
        }

        // Console.WriteLine(string.Join(" ", input.Reverse()));
    }
}
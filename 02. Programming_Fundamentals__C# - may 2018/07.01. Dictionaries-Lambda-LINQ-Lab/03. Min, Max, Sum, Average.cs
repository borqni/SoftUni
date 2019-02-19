using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int[] number = new int[input];

        for (int i = 0; i < input; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Sum = {number.Sum()}");
        Console.WriteLine($"Min = {number.Min()}");
        Console.WriteLine($"Max = {number.Max()}");
        Console.WriteLine($"Average = {number.Average()}");
    }
}
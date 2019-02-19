using System;
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

        for (int i = input - 1; i >= 0; i--)
        {
            Console.Write($"{number[i]} ");
        }
    }
}
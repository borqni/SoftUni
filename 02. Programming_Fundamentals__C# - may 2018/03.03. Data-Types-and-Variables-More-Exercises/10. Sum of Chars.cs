using System;

class test
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < input; i++)
        {
            sum += char.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The sum equals: { sum}");
    }
}
using System;

class test
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string text = "";

        for (int i = 0; i < input; i++)
        {
            text += Console.ReadLine();
        }

        Console.WriteLine($"The word is: { text}");
    }
}
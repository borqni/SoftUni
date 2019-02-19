using System;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();
        int index = text.IndexOf(pattern);
        int counter = 0;

        while (index != -1)
        {
            counter++;
            index = text.IndexOf(pattern, index + 1);
        }

        Console.WriteLine(counter);
    }
}
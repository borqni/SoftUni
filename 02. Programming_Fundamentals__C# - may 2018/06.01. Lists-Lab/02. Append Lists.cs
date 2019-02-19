using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split("|").ToList();
        List<string> result = new List<string>();
        input.Reverse();

        for (int i = 0; i < input.Count; i++)
        {
            string text = input[i];
            string[] splited = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string merged = string.Join(" ", splited);
            result.Add(merged);
        }

        Console.WriteLine(string.Join(" ", result));

        // Console.WriteLine(string.Join(" ", Console.ReadLine()
        //         .Split("|")
        //         .Reverse()
        //         .Select(s => string.Join(" ", s
        //         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)))));
    }
}
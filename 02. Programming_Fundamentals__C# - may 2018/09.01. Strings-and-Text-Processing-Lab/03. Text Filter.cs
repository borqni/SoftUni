using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] banedWords = Console.ReadLine().Split(", ");
        string input = Console.ReadLine();

        foreach (var word in banedWords)
        {
            input = input.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(input);
    }
}
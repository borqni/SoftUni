// 01. Reverse String
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string reverse = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse += input[i];
        }

        Console.WriteLine(reverse);
//        Console.WriteLine(string.Join("", Console.ReadLine().ToCharArray().Reverse().ToArray()));
    }
}


using System;
using System.Linq;
using System.Collections.Generic;

class test
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        char third = char.Parse(Console.ReadLine());

        string word = "" + first + second + third;

        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]);
        }
    }
}

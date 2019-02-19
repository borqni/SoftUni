using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class test
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());

        if (symbol == 'a' ||
            symbol == 'e' ||
            symbol == 'o' ||
            symbol == 'i' ||
            symbol == 'u' ||
            symbol == 'y')
        {
            Console.WriteLine("vowel");
        }
        else if (symbol >= 48 && symbol <= 57)
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

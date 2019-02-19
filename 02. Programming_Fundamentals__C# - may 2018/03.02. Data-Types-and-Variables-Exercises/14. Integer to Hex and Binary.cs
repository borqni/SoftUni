using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class test
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 16).ToUpper());
        Console.WriteLine(Convert.ToString(number, 2));
    }
}

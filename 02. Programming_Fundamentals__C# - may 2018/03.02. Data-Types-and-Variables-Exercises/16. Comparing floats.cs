using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class test
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double diff = Math.Abs(a - b);

        if (diff >= 0.000001)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}

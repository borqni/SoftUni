using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Before: ");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After: ");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}

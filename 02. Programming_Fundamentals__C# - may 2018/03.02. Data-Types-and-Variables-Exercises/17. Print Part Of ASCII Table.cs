using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class test
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());

        for (int i = start; i <= stop; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

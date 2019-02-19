using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string hexaDec = Console.ReadLine();
        int output = Convert.ToInt32(hexaDec, 16);

        Console.WriteLine(output);
    }
}

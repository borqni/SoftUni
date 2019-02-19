using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class test
{
    static void Main()
    {
        string n = Console.ReadLine();

        string m = "";
        try
        {
            sbyte sByte = sbyte.Parse(n);
            m += "* sbyte" + Environment.NewLine;
        }
        catch (Exception) { }

        try
        {
            byte byteA = byte.Parse(n);
            m += "* byte" + Environment.NewLine;
        }
        catch (Exception) { }

        try
        {
            short byteA = short.Parse(n);
            m += "* short" + Environment.NewLine;
        }
        catch (Exception) { }

        try
        {
            ushort byteA = ushort.Parse(n);
            m += "* ushort" + Environment.NewLine;
        }
        catch (Exception) { }

        try
        {
            int byteA = int.Parse(n);
            m += "* int" + Environment.NewLine;
        }
        catch (Exception) { }

        try
        {
            uint byteA = uint.Parse(n);
            m += "* uint" + Environment.NewLine;
        }
        catch (Exception) { }

        try
        {
            long byteA = long.Parse(n);
            m += "* long" + Environment.NewLine;
        }
        catch (Exception) { }

        if (m.Length != 0)
        {
            Console.WriteLine($"{n} can fit in:");
            Console.WriteLine(m);
        }
        else
        {
            Console.Write(n + " ");
            Console.WriteLine($"can't fit in any type");
        }
    }
}

// 04. Draw a Filled Square
using System;

class test
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintHeaderRow(n);
        PrintMiddleRow(n);
        PrintHeaderRow(n);
    }

    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    static void PrintMiddleRow(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("-{0}-", NewStr("\\/", n - 1));
        }
    }

    static string NewStr(string symbol, int count)
    {
        string result = "";

        for (int i = 0; i < count; i++)
        {
            result += symbol;
        }

        return result;
    }
}
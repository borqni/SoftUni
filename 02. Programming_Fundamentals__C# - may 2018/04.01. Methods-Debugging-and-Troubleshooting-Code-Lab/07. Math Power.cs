using System;

class test
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double pow = double.Parse(Console.ReadLine());

        Console.WriteLine(MathPower(n, pow));
    }

    static double MathPower(double n, double pow)
    {
        double result = 1;
        for (double i = 0; i < pow; i++)
        {
            result *= n;
        }
        return result;
    }
}
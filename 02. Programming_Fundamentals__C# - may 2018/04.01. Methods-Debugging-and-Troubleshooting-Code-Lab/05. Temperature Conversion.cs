using System;

class test
{
    static void Main()
    {
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.Write("{0:F2}", celsius);
    }

    static double FahrenheitToCelsius(double degrees)
    {
        double celsius = (degrees - 32) * 5 / 9;
        return celsius;
    }
}
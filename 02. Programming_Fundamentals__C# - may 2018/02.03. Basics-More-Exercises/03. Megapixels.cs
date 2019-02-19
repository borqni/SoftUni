using System;

class test
{
    static void Main(string[] args)
    {
        long width = long.Parse(Console.ReadLine());
        long height = long.Parse(Console.ReadLine());
        double megapixels = (width * height) / 1000000.0;

        Console.WriteLine($"{width}x{height} => {Math.Round(megapixels, 1)}MP");
    }
}

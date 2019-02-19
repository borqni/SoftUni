using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = height * width;

            Console.WriteLine($"{area:F2}");
        }
    }
}
using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double km = 1.60934 * miles;

            Console.WriteLine("{0:F2}", km);
        }
    }
}
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        foreach (var item in numbers)
        {
            int roundNum = (int)Math.Round(item, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{item} => {roundNum}");
        }
    }
}
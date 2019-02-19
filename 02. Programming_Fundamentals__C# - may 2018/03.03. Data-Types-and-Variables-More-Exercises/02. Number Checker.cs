using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine("integer");
        }

        catch (Exception)
        {
            Console.WriteLine("floating-point");
        }
    }
}
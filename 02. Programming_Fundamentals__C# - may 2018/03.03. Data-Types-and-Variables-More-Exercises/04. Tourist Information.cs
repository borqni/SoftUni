using System;

class Program
{
    static void Main(string[] args)
    {
        string inputUnit = Console.ReadLine();
        double inputValue = double.Parse(Console.ReadLine());
        double convert = 0.0;

        if (inputUnit == "miles")
        {
            convert = inputValue * 1.6;
            Console.WriteLine($"{inputValue} {inputUnit} = {convert:f2} kilometers");
        }
        else if (inputUnit == "inches")
        {
            convert = inputValue * 2.54;
            Console.WriteLine($"{inputValue} {inputUnit} = {convert:f2} centimeters");
        }
        else if (inputUnit == "feet")
        {
            convert = inputValue * 30;
            Console.WriteLine($"{inputValue} {inputUnit} = {convert:f2} centimeters");
        }
        else if (inputUnit == "yards")
        {
            convert = inputValue * 0.91;
            Console.WriteLine($"{inputValue} {inputUnit} = {convert:f2} meters");
        }
        else if (inputUnit == "gallons")
        {
            convert = inputValue * 3.8;
            Console.WriteLine($"{inputValue} {inputUnit} = {convert:f2} liters");
        }
    }
}
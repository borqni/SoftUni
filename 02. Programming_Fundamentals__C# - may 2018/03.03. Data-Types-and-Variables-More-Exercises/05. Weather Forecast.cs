using System;

class P05_WeatherForecast
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        try
        {
            sbyte.Parse(input);
            Console.WriteLine("Sunny");
        }
        catch (Exception)
        {
            try
            {
                int.Parse(input);
                Console.WriteLine("Cloudy");
            }
            catch (Exception)
            {
                try
                {
                    long.Parse(input);
                    Console.WriteLine("Windy");
                }
                catch (Exception)
                {
                    try
                    {
                        decimal.Parse(input);
                        Console.WriteLine("Rainy");
                    }
                    catch (Exception) { }
                }
            }
        }
    }
}
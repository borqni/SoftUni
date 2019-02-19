using System;

class test
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        byte remainder = Console.ReadLine() == "even" ? (byte)0 : (byte)1;
        int num = int.Parse(Console.ReadLine());
        string text = "";

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == remainder)
            {
                text += Console.ReadLine() + delimiter;
            }
            else
            {
                Console.ReadLine();
            }
        }

        Console.WriteLine(text.Remove(text.Length - 1));
    }
}
using System;

namespace P14._MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine().ToLower());
            char two = char.Parse(Console.ReadLine().ToLower());
            char three = char.Parse(Console.ReadLine().ToLower());

            for (char i = one; i <= two; i++)
            {
                for (char j = one; j <= two; j++)
                {
                    for (char k = one; k <= two; k++)
                    {
                        if (i != three && j != three && k != three)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
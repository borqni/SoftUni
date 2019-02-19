using System;

class MelrahShake
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string pattern = Console.ReadLine();

        while (true)
        {
            int indxFirst = word.IndexOf(pattern);
            int indxLast = word.LastIndexOf(pattern);

            if (indxFirst == indxLast)
            {
                break;
            }

            Console.WriteLine("Shaked it.");
            word = word.Remove(indxLast, pattern.Length);
            word = word.Remove(indxFirst, pattern.Length);

            pattern = pattern.Remove(pattern.Length / 2, 1);
            if (pattern.Length < 1)
            {
                break;
            }
        }

        Console.WriteLine("No shake.");
        Console.WriteLine(word);
    }
}
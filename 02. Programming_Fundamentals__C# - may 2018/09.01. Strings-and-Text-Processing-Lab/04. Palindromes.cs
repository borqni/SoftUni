using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] words = input.Split(".,!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        List<string> palinrdomes = new List<string>();

        foreach (var word in words)
        {
            bool isPalindrom = IsPalindrom(word);

            if (isPalindrom)
            {
                palinrdomes.Add(word);
            }
        }

        var sorted = palinrdomes.Distinct().OrderBy(w => w);
        Console.WriteLine(string.Join(", ", sorted));
    }

    static bool IsPalindrom(string word)
    {
        string reversed = new string(word.Reverse().ToArray());
        return String.Equals(reversed, word);
    }
}
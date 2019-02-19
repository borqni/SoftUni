using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractSentencesByKeyword
{
    static void Main()
    {
        string searchWord = Console.ReadLine();

        string pattern = $@"\b{searchWord}\b";

        Regex regex = new Regex(pattern);

        string[] words = Console.ReadLine()
            .Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim())
            .ToArray();

        foreach (string word in words)
        {
            if (regex.IsMatch(word))
            {
                Console.WriteLine(word);
            }
        }
    }
}
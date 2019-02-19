using System;
using System.Text.RegularExpressions;

class test
{
    static void Main()
    {
        string input = Console.ReadLine();
        string patern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";

        Regex regex = new Regex(patern);

        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
    }
}
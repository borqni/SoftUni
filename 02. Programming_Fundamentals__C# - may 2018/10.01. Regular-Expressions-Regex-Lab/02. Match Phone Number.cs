//  0/100
using System;
using System.Text.RegularExpressions;

class test
{
    static void Main()
    {
        string input = Console.ReadLine();
        string patern = @"\+359([- ])\d{1}(\1)\d{3}(\1)\d{4}\b";

        Regex regex = new Regex(patern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.Write(string.Join(", ", match));
        }
    }
}













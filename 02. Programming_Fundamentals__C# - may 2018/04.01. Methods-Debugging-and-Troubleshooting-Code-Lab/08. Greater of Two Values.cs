using System;

class test
{
    static void Main()
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "int":
                int firstN = int.Parse(Console.ReadLine());
                int secondN = int.Parse(Console.ReadLine());
                int maxNum = GetMax(firstN, secondN);
                Console.WriteLine(maxNum);
                break;
            case "char":
                char firstCh = char.Parse(Console.ReadLine());
                char secondCh = char.Parse(Console.ReadLine());
                char maxChar = GetMax(firstCh, secondCh);
                Console.WriteLine(maxChar);
                break;
            case "string":
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                string maxStr = GetMax(firstStr, secondStr);
                Console.WriteLine(maxStr);
                break;
        }
    }

    static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        return second;
    }

    static char GetMax(char first, char second)
    {
        if (first >= second)
        {
            return first;
        }
        return second;
    }

    static string GetMax(string first, string second)
    {
        if (first.CompareTo(second) >= 0)
        {
            return first;
        }
        return second;
    }
}
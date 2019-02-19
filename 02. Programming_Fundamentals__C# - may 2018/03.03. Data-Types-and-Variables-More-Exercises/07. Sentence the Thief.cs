using System;

class SentenceTheThief
{
    static void Main()
    {
        string numeralType = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        long maxID = long.MinValue;

        for (int i = 0; i < n; i++)
        {
            long inputID = long.Parse(Console.ReadLine());

            if (numeralType == "sbyte")
            {
                if (inputID > sbyte.MaxValue)
                {
                    continue;
                }
                if (inputID == sbyte.MaxValue)
                {
                    maxID = inputID;
                    break;
                }
                else if (inputID < sbyte.MaxValue)
                {
                    if (inputID > maxID)
                    {
                        maxID = inputID;
                    }
                }
            }
            else if (numeralType == "int")
            {
                if (inputID > int.MaxValue)
                {
                    continue;
                }
                if (inputID == int.MaxValue)
                {
                    maxID = inputID;
                    break;
                }
                else if (inputID < int.MaxValue)
                {
                    if (inputID >= maxID)
                    {
                        maxID = inputID;
                    }
                }
            }
            else if (numeralType == "long")
            {
                if (inputID == long.MaxValue)
                {
                    maxID = inputID;
                    break;
                }
                else if (inputID < long.MaxValue)
                {
                    if (inputID >= maxID)
                    {
                        maxID = inputID;
                    }
                }
            }
        }

        long sentence = 1;

        if (maxID > sbyte.MaxValue)
        {
            sentence = (maxID / 127) + 1;
        }
        else if (maxID < sbyte.MinValue)
        {
            sentence = (maxID / -128) + 1;
        }

        if (sentence > 1)
        {
            Console.WriteLine($"Prisoner with id {maxID} is sentenced to {sentence} years");
        }
        else
        {
            Console.WriteLine($"Prisoner with id {maxID} is sentenced to {sentence} year");
        }
    }
}
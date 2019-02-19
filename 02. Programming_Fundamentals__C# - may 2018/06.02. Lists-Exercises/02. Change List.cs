using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> inputList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string input = Console.ReadLine();

        while (true)
        {
            if (input == "Odd" || input == "Even")
            {
                break;
            }

            string[] command = input.Split();

            if (command[0] == "Delete")
            {
                int elToDelete = int.Parse(command[1]);
                for (int i = 0; i < inputList.Count; i++)
                {
                    inputList.Remove(elToDelete);
                }
            }
            else if (command[0] == "Insert")
            {
                int index = int.Parse(command[2]);
                int num = int.Parse(command[1]);
                inputList.Insert(index, num);
            }

            input = Console.ReadLine();
        }

        List<int> result = new List<int>();

        if (input == "Odd")
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 != 0)
                {
                    result.Add(inputList[i]);
                }
            }
        }

        else
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    result.Add(inputList[i]);
                }
            }
        }

        Console.Write(string.Join(" ", result));
    }
}
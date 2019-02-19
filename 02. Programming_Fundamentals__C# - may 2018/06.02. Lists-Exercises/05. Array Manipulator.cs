using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(num => int.Parse(num))
            .ToList();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "print")
            {
                Console.WriteLine("[" + (string.Join(", ", numbers)) + "]");
                break;
            }

            string[] command = line.Split();
            int index;
            int element;

            switch (command[0])
            {
                case "add":
                    index = int.Parse(command[1]);
                    element = int.Parse(command[2]);
                    numbers.Insert(index, element);
                    break;

                case "addMany":
                    index = int.Parse(command[1]);
                    List<int> elements = new List<int>();

                    for (int i = 2; i < command.Length; i++)
                    {
                        elements.Add(int.Parse(command[i]));
                    }
                    numbers.InsertRange(index, elements);
                    break;
                case "contains":
                    element = int.Parse(command[1]);
                    Console.WriteLine(numbers.IndexOf(element));
                    break;
                case "remove":
                    index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                    break;
                case "shift":
                    int positions = int.Parse(command[1]);
                    for (int i = 0; i < positions % numbers.Count; i++)
                    {
                        int temp = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(temp);
                    }
                    break;
                case "sumPairs":
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                    break;
            }
        }
    }
}
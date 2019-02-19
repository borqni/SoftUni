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

        int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> manipulatedList = new List<int>();

        int takeNums = command[0];
        int deleteNums = command[1];
        int serchNums = command[2];

        for (int i = 0; i < takeNums; i++)
        {
            manipulatedList.Add(inputList[i]);
        }

        for (int i = 0; i < deleteNums; i++)
        {
            manipulatedList.RemoveAt(0);
        }

        if (manipulatedList.Contains(serchNums))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}
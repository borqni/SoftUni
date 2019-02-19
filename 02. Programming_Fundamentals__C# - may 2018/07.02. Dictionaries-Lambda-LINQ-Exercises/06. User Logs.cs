using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLog = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string userName = tokens[tokens.Length - 1];
                string ipAddress = tokens[1];

                if (userLog.ContainsKey(userName) == false)
                {
                    userLog.Add(userName, new Dictionary<string, int>());
                }
                if (userLog[userName].ContainsKey(ipAddress) == false)
                {
                    userLog[userName].Add(ipAddress, 0);
                }

                userLog[userName][ipAddress]++;
            }

            foreach (var user in userLog)
            {
                Console.WriteLine($"{user.Key}:");

                List<string> godHelpMeNow = new List<string>();
                foreach (var item in user.Value)
                {
                    godHelpMeNow.Add($"{item.Key} => {item.Value}");
                }

                Console.Write(String.Join(", ", godHelpMeNow));
                Console.WriteLine(".");
            }
        }
    }
}
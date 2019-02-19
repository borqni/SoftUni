using System;
using System.Linq;
using System.Collections.Generic;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] inputLine = Console.ReadLine()
                .Split(':')
                .ToArray();

                if (inputLine[0] == "JOKER") break;

                string playerName = inputLine[0];
                List<string> cards = inputLine[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (players.ContainsKey(playerName) == false)
                    players.Add(playerName, new List<string>());
                players[playerName].AddRange(cards);
            }

            var powerNames = new List<string>
                { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var powerValues = new List<int>
                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            var powerScoreDict = new Dictionary<string, int>();
            for (int i = 0; i < powerNames.Count; i++)
            {
                powerScoreDict.Add(powerNames[i], powerValues[i]);
            }

            var typeNames = new List<string> { "S", "H", "D", "C" };
            var typeValues = new List<int> { 4, 3, 2, 1 };

            var typeScoreDict = new Dictionary<string, int>();
            for (int i = 0; i < typeNames.Count; i++)
            {
                typeScoreDict.Add(typeNames[i], typeValues[i]);
            }

            foreach (var player in players)
            {
                List<string> unuqueCards = player.Value
                    .Distinct()
                    .ToList();

                int sum = 0;
                foreach (var card in unuqueCards)
                {
                    string type = Convert.ToString(card[card.Length - 1]);
                    string power = card.Remove(card.Length - 1, 1);

                    int typeValue = typeScoreDict[type];
                    int powerValue = powerScoreDict[power];

                    sum += powerValue * typeValue;
                }

                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}
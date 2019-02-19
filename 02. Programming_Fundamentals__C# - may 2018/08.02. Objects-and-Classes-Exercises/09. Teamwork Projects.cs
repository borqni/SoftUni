using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Teams database
            List<Team> allTeams = new List<Team>();
            // Store users and creators, to check if already members of any team
            List<string> allUsers = new List<string>();

            // Create teams
            int teamsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string creatorName = tokens[0];
                string teamName = tokens[1];

                // Don't create a team twice
                if (allTeams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                    continue;
                }
                // Creator already started a team
                else if (allTeams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine("{0} cannot create another team!", creatorName);
                    continue;
                }
                // Create team
                else
                {
                    Team newTeam = new Team
                    {
                        Name = teamName,
                        Creator = creatorName,
                        Members = new List<string>()
                    };

                    allTeams.Add(newTeam);
                    allUsers.Add(creatorName);

                    Console.WriteLine("Team {0} has been created by {1}!", teamName, creatorName);
                }
            }

            // Join users
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment") { break; }

                string[] tokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string userName = tokens[0];
                string teamName = tokens[1];

                // User trying to join a non-existing team
                if (allTeams.Any(t => t.Name == teamName) == false)
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                    continue;
                }
                // User is already a member (or creator) of a group
                else if (allUsers.Contains(userName))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", userName, teamName);
                    continue;
                }
                else
                {
                    // Add members to team
                    allTeams.First(t => t.Name == teamName).Members.Add(userName);
                    // Add user to list of all users who already joined a team
                    allUsers.Add(userName);
                }
            }

            // Teams with members
            List<Team> validTeams = allTeams.Where(t => t.Members.Count > 0).ToList();
            validTeams = validTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();
            // Tems with only a creator
            List<Team> disbandTeams = allTeams.Where(t => t.Members.Count == 0).ToList();
            disbandTeams = disbandTeams.OrderBy(t => t.Name).ToList();

            // Print valid teams data
            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);

                team.Members = team.Members.OrderBy(m => m).ToList();
                foreach (string member in team.Members)
                {
                    Console.WriteLine("-- " + member);
                }
            }

            // Print invalid teams
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
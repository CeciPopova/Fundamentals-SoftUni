using System;
using System.Collections.Generic;
using System.Linq;


namespace P05._Teamwork_Projects
{
    internal class Program
    {
        class Team
        {
            public Team(string name, string creator)
            {
                this.Name = name;
                this.Creator = creator;
                this.Members = new List<string>();
            }
            public string Name { get; set; }
            public string Creator { get; set; }

            public List<string> Members { get; set; }

            public void AddMembers(string member)
            {
                Members.Add(member);
            }
        }
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 1; i <= countOfTeams; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creatorName = newTeam[0];
                string teamName = newTeam[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                Team team = new Team(teamName, creatorName);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string[] arr = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = arr[0];
                string teamName = arr[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.Name == teamName);
                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    command = Console.ReadLine();
                    continue;
                }
                if (teams.Any(t => t.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    command = Console.ReadLine();
                    continue;
                }

                if (teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    command = Console.ReadLine();
                    continue;
                }

                searchedTeam.AddMembers(memberName);
                command = Console.ReadLine();
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            List<Team> nonValidTeams = teams.Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();
            foreach (Team validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.Name}");
                Console.WriteLine($"- {validTeam.Creator}");
                foreach (string member in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (Team invalidTeam in nonValidTeams)
            {
                Console.WriteLine($"{invalidTeam.Name}");
            }

        }

    }
}
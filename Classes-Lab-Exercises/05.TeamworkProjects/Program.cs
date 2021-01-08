using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");
                string creatorname = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(teamName, creatorname);

                bool isTeamNameExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorNameExist = teams.Select(x => x.CreatorName).Contains(creatorname);

                if (!isTeamNameExist)
                {
                    if (!isCreatorNameExist)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorname}!");
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} cannot create another team!");
                    }

                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string teammembers = Console.ReadLine();

            while (teammembers != "end of assignment")
            {
                string[] cmdArg = teammembers.Split(new char[] {'-','>'}).ToArray();
                string newUser = cmdArg[0];
                string teamName = cmdArg[1];

                bool isTeamexist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.CreatorName).Contains(newUser);
                bool isMemberExist = teams.Select(x => x.Membars).Any(x => x.Contains(newUser));
                if (!isTeamexist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if(isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Membars.Add(newUser);
                }
                teammembers = Console.ReadLine();
            }

            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Membars.Count == 0).ToArray();

            Team[] fullTeam = teams.OrderByDescending(x => x.Membars.Count)
                .ThenBy(x => x.TeamName)
                .Where(x => x.Membars.Count > 0)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeam)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.CreatorName}");

                foreach (var member in team.Membars.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }

                sb.AppendLine("Teams to disband:");

                foreach (Team item in teamsToDisband)
                {
                    sb.AppendLine(item.TeamName);
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }

    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Membars = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Membars { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DemoTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<string>
        }
    }

    class Team
    {

        public Team(string userTeam, string creator)
        {
            TeamUser = userTeam;
            CreatorName = creator;
            Members = new List<string>();

        }

        public string TeamUser { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }







    }

}


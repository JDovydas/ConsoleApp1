using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Paskaita_Generics_P2
{
    public class SportsLeague<T> where T : Team
    {
        private List<T> Teams { get; set; }

        public SportsLeague()
        {
            Teams = new List<T>();
        }

        public void AddTeam(T team)
        {
            if (Teams.Count == 0 || Teams[0].Sport == team.Sport)
            {
                Teams.Add(team);
                Console.WriteLine($"Team '{team.Name}' added to the {team.Sport} league.");
            }
            else
            {
                Console.WriteLine($"Error: Cannot add a team from a different sport to the {Teams[0].Sport} league.");
            }
        }

        public void PrintTeams()
        {
            Console.WriteLine($"Teams in the league:");
            foreach (T team in Teams)
            {
                Console.WriteLine($"Name: {team.Name}, Sport: {team.Sport}");
            }
        }




    }
}

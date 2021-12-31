using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class FootballPlayer: Player, IPlayerTeam
    {
        private LSP.Team Team { get; set; }

        public string GetTeam() => Team.Name;

        //public void AssignTeam(Team team)
        //{
        //    Team = team;
        //}


        public string GetMarketValue(PlayerCategory category)
        {
            string marketvalue = "";
            switch (category)
            {
                case PlayerCategory.Amateur:
                    marketvalue = "100";
                    break;
                case PlayerCategory.Professional:
                    marketvalue = "1000";
                    break;
            }
            return marketvalue;
        }

        public void AssignTeam(LSP.Team team)
        {
            Team = team;
        }
    }
}
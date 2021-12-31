using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public interface IPlayerTeam : IPlayer
    {
        public void AssignTeam(Team team);

        public string GetTeam();
    }
}

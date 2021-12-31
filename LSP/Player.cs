using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PlayerCategory Category { get; set; }

        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }

        public class Team
        {
            public string Name { get; set; }
        }
    }
}

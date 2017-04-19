using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class Game
    {
        public int ID { get; set; }       
        public string Score { get; set; }

        public int? AwayTeamID { get; set; }
        public Team AwayTeam { get; set; }

        public int? HomeTeamID { get; set; }
        public Team HomeTeam { get; set; }

    }
}
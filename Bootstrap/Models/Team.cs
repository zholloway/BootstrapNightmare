using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }       
        public int NumberOfPlayers { get; set; }

        public int SportID { get; set; }
        public Sport Sport { get; set; }
    }
}
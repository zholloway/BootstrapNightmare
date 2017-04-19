using Bootstrap.DataContext;
using Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Services
{
    public class TeamServices
    {
        public TIYSportsContext Database { get; set; }
        public TeamServices(TIYSportsContext database)
        {
            Database = database;
        }

        public List<Team> GetAllTeams()
        {
            var list = Database.Teams.ToList();
            return list;
        }
    }
}
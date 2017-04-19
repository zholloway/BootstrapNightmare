using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.DataContext;
using Bootstrap.Models;
using Bootstrap.Services;

namespace Bootstrap.ViewModel
{
    public class IndexVM
    {
        public List<Team> Teams { get; set; }
        public List<Game> Games { get; set; }
        public List<Sport> Sports { get; set; }

        public IndexVM(List<Team>getTeams, List<Sport>getSports, List<Game> getGames )
        {
            Teams = getTeams;
            Sports = getSports;
            Games = getGames;
        }
    }
}
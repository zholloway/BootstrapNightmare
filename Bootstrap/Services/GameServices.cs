using Bootstrap.DataContext;
using Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Services
{
    public class GameServices
    {
        public TIYSportsContext Database { get; set; }
        public GameServices(TIYSportsContext database)
        {
            Database = database;
        }

        public List<Game> GetAllGames()
        {
            var list = Database.Games.ToList();
            return list;
        }
    }
}
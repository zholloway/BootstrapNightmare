using Bootstrap.DataContext;
using Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Services
{
    public class SportServices
    {
        public TIYSportsContext Database { get; set; }
        public SportServices(TIYSportsContext database)
        {
            Database = database;
        }

        public List<Sport> GetAllSports()
        {
            var list = Database.Sports.ToList();
            return list;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bootstrap.Models;

namespace Bootstrap.DataContext
{
    public class TIYSportsContext :DbContext
    {
        public TIYSportsContext():base() { }

        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
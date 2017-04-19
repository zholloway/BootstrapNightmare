using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class Sport
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
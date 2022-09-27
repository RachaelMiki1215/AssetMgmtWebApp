using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class Team
    {
        public Team()
        {
            Labs = new HashSet<Lab>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Abbreviation { get; set; } = null!;
        public string Organization { get; set; } = null!;
        public int? LeaderId { get; set; }

        public virtual User? Leader { get; set; }
        public virtual ICollection<Lab> Labs { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

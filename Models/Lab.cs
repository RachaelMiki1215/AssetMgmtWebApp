using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class Lab
    {
        public Lab()
        {
            Environments = new HashSet<Environment>();
            Equipment = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int? OwnerUserId { get; set; }
        public int? OwnerTeamId { get; set; }
        public string? Note { get; set; }

        public virtual Team? OwnerTeam { get; set; }
        public virtual User? OwnerUser { get; set; }
        public virtual ICollection<Environment> Environments { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}

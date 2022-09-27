using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class Environment
    {
        public Environment()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int? LabId { get; set; }
        public string? Note { get; set; }

        public virtual Lab? Lab { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}

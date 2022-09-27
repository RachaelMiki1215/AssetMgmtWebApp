using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class MaintenanceRecord
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public DateTime Date { get; set; }
        public int MaintainedUserId { get; set; }
        public string Details { get; set; } = null!;

        public virtual Equipment Equipment { get; set; } = null!;
        public virtual User MaintainedUser { get; set; } = null!;
    }
}

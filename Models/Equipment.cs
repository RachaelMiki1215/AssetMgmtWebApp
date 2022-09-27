using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            MaintenanceRecords = new HashSet<MaintenanceRecord>();
            ReservationRecords = new HashSet<ReservationRecord>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Condition { get; set; } = null!;
        public string? Location { get; set; }
        public int? LabId { get; set; }
        public int? EnvironmentId { get; set; }

        public virtual Environment? Environment { get; set; }
        public virtual Lab? Lab { get; set; }
        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; }
        public virtual ICollection<ReservationRecord> ReservationRecords { get; set; }
    }
}

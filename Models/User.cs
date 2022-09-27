using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class User
    {
        public User()
        {
            Labs = new HashSet<Lab>();
            MaintenanceRecords = new HashSet<MaintenanceRecord>();
            NewsArticles = new HashSet<NewsArticle>();
            ReservationRecords = new HashSet<ReservationRecord>();
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public int? TeamId { get; set; }
        public string? Role { get; set; }

        public virtual Team? Team { get; set; }
        public virtual ICollection<Lab> Labs { get; set; }
        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; }
        public virtual ICollection<NewsArticle> NewsArticles { get; set; }
        public virtual ICollection<ReservationRecord> ReservationRecords { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}

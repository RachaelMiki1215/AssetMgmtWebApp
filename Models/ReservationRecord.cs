using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class ReservationRecord
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Purpose { get; set; } = null!;
        public string? PurposeDetails { get; set; }
        public int BorrowerUserId { get; set; }
        public bool IsRetrieveAssistNeeded { get; set; }
        public string? RetrieveAssistReason { get; set; }
        public string? Note { get; set; }
        public string ApprovalStatus { get; set; } = null!;
        public string ApprovalStatusReason { get; set; } = null!;
        public string UsageStatus { get; set; } = null!;

        public virtual User BorrowerUser { get; set; } = null!;
        public virtual Equipment Equipment { get; set; } = null!;
    }
}

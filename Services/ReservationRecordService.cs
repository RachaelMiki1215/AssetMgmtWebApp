using AssetMgmtWebApp3.Data;
using Microsoft.EntityFrameworkCore;
using AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Services
{
    public class ReservationRecordService
    {
        private AppDbContext _context;

        public ReservationRecordService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ReservationRecord> GetEnvironments()
        {
            // TODO: Need actual code.
            return new List<ReservationRecord>();
        }
    }
}

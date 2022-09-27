using AssetMgmtWebApp3.Data;
using Microsoft.EntityFrameworkCore;
using AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Services
{
    public class MaintenanceRecordService
    {
        private AppDbContext _context;

        public MaintenanceRecordService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MaintenanceRecord> GetEnvironments()
        {
            // TODO: Need actual code.
            return new List<MaintenanceRecord>();
        }
    }
}

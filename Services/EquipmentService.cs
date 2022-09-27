using AssetMgmtWebApp3.Data;
using Microsoft.EntityFrameworkCore;
using AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Services
{
    public class EquipmentService
    {
        private AppDbContext _context;

        public EquipmentService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Equipment> GetEquipment()
        {
            // TODO: Need actual code.
            return new List<Equipment>();
        }
    }
}

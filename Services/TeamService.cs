using AssetMgmtWebApp3.Data;
using Microsoft.EntityFrameworkCore;
using AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Services
{
    public class TeamService
    {
        private AppDbContext _context;

        public TeamService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Team> GetEnvironments()
        {
            // TODO: Need actual code.
            return new List<Team>();
        }
    }
}

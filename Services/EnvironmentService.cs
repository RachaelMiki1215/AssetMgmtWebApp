using AssetMgmtWebApp3.Data;
using Microsoft.EntityFrameworkCore;
using Models = AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Services
{
    public class EnvironmentService
    {
        private AppDbContext _context;

        public EnvironmentService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.Environment> GetEnvironments(
            string? type = null, string? name = null, int? labId = null)
        {
            IQueryable<Models.Environment> environments = _context.Environments;
            if (type != null)
            {
                environments = environments.Where(e => e.Type == type);
            }
            if (name != null)
            {
                environments = environments.Where(e => e.Name == name);
            }
            if (labId != null)
            {
                environments = environments.Where(e => e.LabId == labId);
            }

            return environments.OrderBy(e => e.Id);
        }

        public Models.Environment? GetEnvironment(int Id)
        {
            return _context.Environments.SingleOrDefault(e => e.Id == Id);
        }
    }
}

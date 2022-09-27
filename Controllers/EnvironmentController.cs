using Microsoft.AspNetCore.Mvc;
using AssetMgmtWebApp3.Data;
using Models = AssetMgmtWebApp3.Models;
using AssetMgmtWebApp3.Services;

namespace AssetMgmtWebApp3.Controllers
{
    public class EnvironmentController : ControllerBase
    {
        private AppDbContext _context;

        public EnvironmentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("search")]
        public IEnumerable<Models.Environment> GetEnvironments(
            string? type = null, string? name = null, int? labId = null)
        {
            return (new EnvironmentService(_context))
                .GetEnvironments(type, name, labId).ToArray();
        }

        [HttpGet("{id}")]
        public Models.Environment? GetEnvironment(int id)
        {
            return (new EnvironmentService(_context))
                .GetEnvironment(id);
        }
    }
}

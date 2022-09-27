using Microsoft.AspNetCore.Mvc;
using AssetMgmtWebApp3.Data;
using AssetMgmtWebApp3.Models;
using AssetMgmtWebApp3.Services;

namespace AssetMgmtWebApp3.Controllers
{
    public class TeamController : ControllerBase
    {
        private AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        //TODO: Add methods.
    }
}

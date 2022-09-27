using Microsoft.AspNetCore.Mvc;
using AssetMgmtWebApp3.Data;
using AssetMgmtWebApp3.Models;
using AssetMgmtWebApp3.Services;

namespace AssetMgmtWebApp3.Controllers
{
    public class UserController : ControllerBase
    {
        private AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        //TODO: Add methods.
    }
}

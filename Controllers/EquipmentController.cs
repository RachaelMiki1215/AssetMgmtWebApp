using Microsoft.AspNetCore.Mvc;
using AssetMgmtWebApp3.Data;
using AssetMgmtWebApp3.Models;
using AssetMgmtWebApp3.Services;

namespace AssetMgmtWebApp3.Controllers
{
    public class EquipmentController : ControllerBase
    {
        private AppDbContext _context;

        public EquipmentController(AppDbContext context)
        {
            _context = context;
        }

        //TODO: Add methods.
    }
}

﻿using AssetMgmtWebApp3.Data;
using Microsoft.EntityFrameworkCore;
using AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Services
{
    public class LabService
    {
        private AppDbContext _context;

        public LabService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lab> GetEnvironments()
        {
            // TODO: Need actual code.
            return new List<Lab>();
        }
    }
}

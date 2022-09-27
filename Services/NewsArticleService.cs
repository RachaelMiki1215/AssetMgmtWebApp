using AssetMgmtWebApp3.Data;
using Microsoft.EntityFrameworkCore;
using AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Services
{
    public class NewsArticleService
    {
        private AppDbContext _context;

        public NewsArticleService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<NewsArticle> GetEnvironments()
        {
            // TODO: Need actual code.
            return new List<NewsArticle>();
        }
    }
}

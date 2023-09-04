using AllupProjectT.DataAccessLayer;
using AllupProjectT.Models;
using Microsoft.EntityFrameworkCore;

namespace AllupProjectT.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Setting>> GetSettingsAsync() 
        {
          List<Setting> settings = await _context.Settings.ToListAsync();
            return settings;
        }
    }
}

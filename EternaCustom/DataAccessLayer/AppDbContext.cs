using Microsoft.EntityFrameworkCore;

namespace EternaCustom.DataAccessLayer
{
    public class AppDbContext : DbContext    
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) :base(options)
        {
            
        }
    }
}

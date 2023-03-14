using Microsoft.EntityFrameworkCore;

namespace YemekKitabı.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
    }
}

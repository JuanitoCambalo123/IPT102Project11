using Microsoft.EntityFrameworkCore;

namespace FoodOrdering.Data.Enums
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}

using Purple.Vipers.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Purple.Vipers.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
            : base(options)
        {   }

        public DbSet<Item> Items { get; set; }
    }
}

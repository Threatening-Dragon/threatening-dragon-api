using threatening.dragon.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace threatening.dragon.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {  }

        public DbSet<Item> Items { get; set; }
    }
}
public class Class1
{

}

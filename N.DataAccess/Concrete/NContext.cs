using System.Data.Entity;
using N.Entites.Concrete;

namespace N.DataAccess.Concrete
{
    public class NContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
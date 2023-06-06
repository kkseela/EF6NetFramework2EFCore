using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Ef6.netFramework
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}

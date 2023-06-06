using Microsoft.EntityFrameworkCore;

namespace EFCorePorting
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Database
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SampleEF6netframeworkNew;Integrated Security=True;");
        }
    }
}

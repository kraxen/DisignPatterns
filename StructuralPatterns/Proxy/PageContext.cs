using Microsoft.EntityFrameworkCore;

namespace StructuralPatterns.Proxy
{
    public class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookPagesDB;Trusted_Connection=True;");
        }
    }
}

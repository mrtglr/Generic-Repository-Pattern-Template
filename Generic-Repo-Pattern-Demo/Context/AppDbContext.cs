using Generic_Repo_Pattern_Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repo_Pattern_Demo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

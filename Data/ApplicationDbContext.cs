using Microsoft.EntityFrameworkCore;
using Project2.Model;

namespace Project2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Person> personTables { get; set; }
    }
}

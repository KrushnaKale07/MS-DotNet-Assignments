using Microsoft.EntityFrameworkCore;
using WebApplDay9.Models;

namespace WebApplDay9.Data
{
    public class Day9DbContext : DbContext
    {
        public Day9DbContext(DbContextOptions<Day9DbContext> options) : base(options) { 
             
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Contry> Contries { get; set; }
    }
}

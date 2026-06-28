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
        public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            base.OnModelCreating(modelBuilder);
           
            //Fluent API

            modelBuilder.Entity<Contry>()
                .HasMany(c => c.States)
                .WithOne(s => s.Contry)
                .HasForeignKey(s => s.ContryId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}

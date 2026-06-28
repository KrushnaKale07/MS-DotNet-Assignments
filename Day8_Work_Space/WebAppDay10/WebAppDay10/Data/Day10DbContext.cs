using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAppDay10.Data
{
    public class Day10DbContext : IdentityDbContext
    {
        public Day10DbContext(DbContextOptions<Day10DbContext> options) : base(options)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;

public class MVCWebAppTestContext(DbContextOptions<MVCWebAppTestContext> options) : DbContext(options)
{
    public DbSet<MVCWebAppTest.Models.Product> Product { get; set; } = default!;
}

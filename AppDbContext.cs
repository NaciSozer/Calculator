
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Calculation> Calculations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=calculator.db");
    }

}
using Microsoft.EntityFrameworkCore;
using UnoSquareTest.Models.Entities;

namespace UnoSquareTest.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TaskUS> Tasks { get; set; }
    }
}

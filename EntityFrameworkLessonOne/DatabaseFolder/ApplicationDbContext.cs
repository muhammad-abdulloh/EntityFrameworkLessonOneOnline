using EntityFrameworkLessonOne.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLessonOne.DatabaseFolder
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}

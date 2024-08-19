using Microsoft.EntityFrameworkCore;

namespace AtvDb.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}

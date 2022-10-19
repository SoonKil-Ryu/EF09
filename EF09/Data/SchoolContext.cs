using EF09.Models;
using Microsoft.EntityFrameworkCore;

namespace EF09.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Score> Scores { get; set; }

    }
}

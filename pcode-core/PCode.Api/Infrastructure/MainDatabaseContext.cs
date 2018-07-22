using Microsoft.EntityFrameworkCore;
using PCode.Domain;

namespace PCode.Api.Infrastructure
{
    public class MainDatabaseContext : DbContext
    {
        public MainDatabaseContext(DbContextOptions<MainDatabaseContext> options)
            : base(options)
        { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using PCode.Domain;

namespace PCode.Api.Infrastructure
{
    public class PcodeContext : DbContext
    {
        public PcodeContext(DbContextOptions<PcodeContext> options)
            : base(options)
        { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}

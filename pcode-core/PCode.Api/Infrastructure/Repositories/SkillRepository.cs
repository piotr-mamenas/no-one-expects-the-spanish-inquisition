using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Infrastructure.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly MainDatabaseContext _context;

        public SkillRepository(MainDatabaseContext context)
        {
            _context = context;
        }
    }
}

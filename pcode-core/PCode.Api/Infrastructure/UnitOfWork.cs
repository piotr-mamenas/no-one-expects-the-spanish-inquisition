using System.Threading.Tasks;
using PCode.Api.Infrastructure.Repositories;
using PCode.Domain.Interfaces;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainDatabaseContext _context;

        public UnitOfWork(MainDatabaseContext context)
        {
            _context = context;

            _profiles = new ProfileRepository(_context);
            _skills = new SkillRepository(context);
        }

        private readonly IProfileRepository _profiles;
        private readonly ISkillRepository _skills;

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

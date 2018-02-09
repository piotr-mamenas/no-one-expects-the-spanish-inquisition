using System.Threading.Tasks;
using PCode.Api.Infrastructure.Repositories;
using PCode.Domain.Interfaces;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PcodeContext _context;

        public UnitOfWork(PcodeContext context)
        {
            _context = context;
            Profiles = new ProfileRepository(_context);
            Skills = new SkillRepository(context);
        }

        private IProfileRepository Profiles { get; }
        private ISkillRepository Skills { get; }

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

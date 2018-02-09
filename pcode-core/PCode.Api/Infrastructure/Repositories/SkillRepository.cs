using PCode.Domain;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Infrastructure.Repositories
{
    public class SkillRepository : Repository<Skill>, ISkillRepository
    {
        public SkillRepository(PcodeContext context)
            : base(context)
        {
        }
    }
}

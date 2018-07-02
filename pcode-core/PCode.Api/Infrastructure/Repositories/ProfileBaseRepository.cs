using PCode.Domain;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Infrastructure.Repositories
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(PcodeContext context)
            : base(context)
        {
        }
    }
}

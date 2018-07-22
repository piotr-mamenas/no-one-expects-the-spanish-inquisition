using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCode.Domain.Interfaces.Repositories
{
    public interface IProfileRepository
    {
        Task<IEnumerable<Profile>> GetAllProfilesAsync();
    }
}
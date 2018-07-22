using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PCode.Domain;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Infrastructure.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly MainDatabaseContext _context;

        public ProfileRepository(MainDatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profile>> GetAllProfilesAsync()
        {
            return await _context.Profiles.ToListAsync();
        }
    }
}

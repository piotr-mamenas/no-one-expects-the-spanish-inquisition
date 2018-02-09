using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCode.Domain;
using PCode.Domain.Interfaces;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/profiles")]
    public class ProfilesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProfileRepository _profileRepository;

        public ProfilesController(IProfileRepository profileRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _profileRepository = profileRepository;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Profile>> GetProfiles()
        {
            return await _profileRepository.FindAsync(p => p.IsDeleted == false);
        }
    }
}
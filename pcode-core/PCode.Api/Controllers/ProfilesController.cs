using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PCode.Api.Resources;
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
        private readonly IMapper _mapper;

        public ProfilesController(IProfileRepository profileRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _profileRepository = profileRepository;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<IEnumerable<ProfileResource>> GetProfiles()
        {
            var profiles = await _profileRepository.FindAsync(p => true);
            
            return _mapper.Map<IEnumerable<Domain.Profile>, IEnumerable<ProfileResource>>(profiles);
        }
    }
}
using PCode.Api.Resources;
using PCode.Domain;

namespace PCode.Api.Mapping
{
    public class ProfileMapping : AutoMapper.Profile
    {
        public ProfileMapping()
        {
            CreateMap<ProfileResource, Profile>().ReverseMap();

            CreateMap<SkillResource, Skill>().ReverseMap();
        }
    }
}

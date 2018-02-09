using System;
using System.Collections.Generic;

namespace PCode.Api.Resources
{
    public class ProfileResource
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Level { get; set; }

        public ICollection<SkillResource> Skills { get; set; }

        public ProfileResource()
        {
            Skills = new List<SkillResource>();
        }
    }
}

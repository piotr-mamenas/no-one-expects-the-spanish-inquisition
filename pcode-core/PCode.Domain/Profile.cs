using System.Collections.Generic;
using PCode.Domain.Interfaces;

namespace PCode.Domain
{
    public class Profile : BaseEntity, IEntityRoot
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Level { get; set; }

        public ICollection<Skill> Skills { get; set; }

        public Profile()
        {
            Skills = new List<Skill>();
        }
    }
}

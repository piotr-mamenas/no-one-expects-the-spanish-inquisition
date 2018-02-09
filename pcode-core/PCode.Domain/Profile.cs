using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PCode.Domain
{
    public class Profile
    {
        [Key]
        public Guid Guid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Level { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}

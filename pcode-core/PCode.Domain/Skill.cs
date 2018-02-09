using System;
using System.ComponentModel.DataAnnotations;

namespace PCode.Domain
{
    public class Skill
    {
        [Key]
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Score { get; set; }
    }
}

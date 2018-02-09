using System;
using System.ComponentModel.DataAnnotations;

namespace PCode.Domain
{
    public class BaseEntity
    {
        [Key]
        public Guid Guid { get; set; }

        public bool IsDeleted { get; set; }
    }
}

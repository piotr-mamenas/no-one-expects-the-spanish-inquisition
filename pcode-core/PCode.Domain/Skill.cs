using PCode.Domain.Interfaces;

namespace PCode.Domain
{
    public class Skill : BaseEntity, IEntityRoot
    {
        public string Name { get; set; }

        public string Score { get; set; }
    }
}

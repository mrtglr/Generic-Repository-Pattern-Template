using Generic_Repo_Pattern_Demo.Base.Interfaces;

namespace Generic_Repo_Pattern_Demo.Base
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

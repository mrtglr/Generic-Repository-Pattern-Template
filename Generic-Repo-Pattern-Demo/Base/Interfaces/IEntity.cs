namespace Generic_Repo_Pattern_Demo.Base.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

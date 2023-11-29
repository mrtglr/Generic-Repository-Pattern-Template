using Generic_Repo_Pattern_Demo.Base;

namespace Generic_Repo_Pattern_Demo.Model
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}

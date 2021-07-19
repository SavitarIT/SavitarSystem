namespace Savitar.Web.Server.Models
{
    public class ProjectTechnologyCategory : Entity
    {
        public ProjectTechnologyCategory() {}

        public ProjectTechnologyCategory(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
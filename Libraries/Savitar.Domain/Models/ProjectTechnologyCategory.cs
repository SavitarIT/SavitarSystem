namespace Savitar.Domain.Models
{
    public class ProjectTechnologyCategory : Entity
    {
        internal static int lastId = 0;

        public ProjectTechnologyCategory() {}
   
        public string Name { get; init; }
    }
}
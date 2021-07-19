using Savitar.Web.Client.Models;

namespace Savitar.Web.Server.Data
{
    public static class TechnologyCategories
    {
        public static readonly ProjectTechnologyCategory IDE =
            new ProjectTechnologyCategory("IDE");

        public static readonly ProjectTechnologyCategory Language = new ProjectTechnologyCategory("Language");
        public static readonly ProjectTechnologyCategory Framework = new ProjectTechnologyCategory("Framework");
        public static readonly ProjectTechnologyCategory Database = new ProjectTechnologyCategory("Database");
        public static readonly ProjectTechnologyCategory ORM = new ProjectTechnologyCategory("ORM");
        public static readonly ProjectTechnologyCategory Tool = new ProjectTechnologyCategory("Tool");
    }
}
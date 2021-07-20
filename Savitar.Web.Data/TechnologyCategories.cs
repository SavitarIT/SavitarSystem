using Savitar.Web.Models;

namespace Savitar.Web.Data
{
    internal static class TechnologyCategories
    {
        public static readonly ProjectTechnologyCategory IDE = new("IDE");
        public static readonly ProjectTechnologyCategory Language = new("Language");
        public static readonly ProjectTechnologyCategory Framework = new("Framework");
        public static readonly ProjectTechnologyCategory Database = new("Database");
        public static readonly ProjectTechnologyCategory ORM = new("ORM");
        public static readonly ProjectTechnologyCategory Tool = new("Tool");
    }
}
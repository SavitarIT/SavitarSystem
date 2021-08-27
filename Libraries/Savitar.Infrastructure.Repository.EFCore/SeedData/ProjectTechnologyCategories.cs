using System.Collections.Generic;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.SeedData
{
    public static class ProjectTechnologyCategories
    {
        public static readonly ProjectTechnologyCategory IDE = new() { Id = 1, Name = "IDE" };
        public static readonly ProjectTechnologyCategory Language = new() { Id = 2, Name = "Language" };
        public static readonly ProjectTechnologyCategory Framework = new() { Id = 3, Name = "Framework" };
        public static readonly ProjectTechnologyCategory Database = new() { Id = 4, Name = "Database" };
        public static readonly ProjectTechnologyCategory ORM = new() { Id = 5, Name = "ORM" };
        public static readonly ProjectTechnologyCategory Tool = new() { Id = 6, Name = "Tool" };

        public static IEnumerable<ProjectTechnologyCategory> GetAll()
        {
            return new List<ProjectTechnologyCategory>()
            {
                IDE, Language, Framework, Database, ORM, Tool
            };
        }
    }
}
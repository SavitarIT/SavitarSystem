using System.Collections.Generic;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.SeedData
{
    public static class DevelopmentTechnologyCategories
    {
        public static readonly DevelopmentTechnologyCategory IDE = new() { Id = 1, Name = "IDE" };
        public static readonly DevelopmentTechnologyCategory Language = new() { Id = 2, Name = "Language" };
        public static readonly DevelopmentTechnologyCategory Framework = new() { Id = 3, Name = "Framework" };
        public static readonly DevelopmentTechnologyCategory Database = new() { Id = 4, Name = "Database" };
        public static readonly DevelopmentTechnologyCategory ORM = new() { Id = 5, Name = "ORM" };
        public static readonly DevelopmentTechnologyCategory Tool = new() { Id = 6, Name = "Tool" };

        public static IEnumerable<DevelopmentTechnologyCategory> GetAll()
        {
            return new List<DevelopmentTechnologyCategory>()
            {
                IDE, Language, Framework, Database, ORM, Tool
            };
        }
    }
}
using System.Collections.Generic;
using Savitar.Domain.Models.CV;

namespace Savitar.Infrastructure.Repository.SeedData
{
    public static class ResponsibilitiesSeedData
    {
        public static readonly ProjectResponsibility LeadDevResponsibility = new() { Id = 1, Name = "Lead Developer" };
        public static readonly ProjectResponsibility SeniorDevResponsibility = new() { Id = 2, Name = "Senior Developer" };
        public static readonly ProjectResponsibility MentorResponsibility = new() { Id = 3, Name = "Mentor" };

        public static IEnumerable<ProjectResponsibility> GetAll()
        {
            return new List<ProjectResponsibility>
            {
                LeadDevResponsibility, MentorResponsibility
            };
        }
    }
}
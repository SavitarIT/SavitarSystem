using System.Collections.Generic;
using Savitar.Web.Models;

namespace Savitar.Web.Data.CV
{
    internal class Responsibilities
    {
        public static readonly ProjectResponsibility LeadDevResponsibility = new ProjectResponsibility { Id = 1, Name = "Lead Developer" };
        public static readonly ProjectResponsibility SeniorDevResponsibility = new ProjectResponsibility { Id = 2, Name = "Senior Developer" };
        public static readonly ProjectResponsibility MentorResponsibility = new ProjectResponsibility { Id = 3, Name = "Mentor" };

        public static IEnumerable<ProjectResponsibility> GetAll()
        {
            return new List<ProjectResponsibility>
            {
                LeadDevResponsibility, MentorResponsibility
            };
        }
    }
}
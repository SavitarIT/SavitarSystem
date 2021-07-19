using System.Collections.Generic;
using Savitar.Web.Client.Models;

namespace Savitar.Web.Server.Data
{
    public static class Responsibilities
    {
        public static readonly ProjectResponsibility LeadDevResponsibility = new ProjectResponsibility { Name = "Lead Developer" };
        public static readonly ProjectResponsibility SeniorDevResponsibility = new ProjectResponsibility { Name = "Senior Developer" };
        public static readonly ProjectResponsibility MentorResponsibility = new ProjectResponsibility { Name = "Mentor" };

        public static IEnumerable<ProjectResponsibility> GetAll()
        {
            return new List<ProjectResponsibility>
            {
                LeadDevResponsibility, MentorResponsibility
            };
        }
    }
}
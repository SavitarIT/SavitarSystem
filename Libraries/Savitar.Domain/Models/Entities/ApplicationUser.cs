using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Savitar.Domain.Shared;

namespace Savitar.Domain.Models.Entities
{
    public class ApplicationUser : IdentityUser<int>, IEntity
    {
        [Required, StringLength(250)]
        public string FirstName { get; set; }
        [Required, StringLength(250)]
        public string LastName { get; set; }
    }
}

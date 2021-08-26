using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required, StringLength(250)]
        public string FirstName { get; set; }
        [Required, StringLength(250)]
        public string LastName { get; set; }
    }
}

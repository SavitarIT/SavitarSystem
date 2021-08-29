using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Savitar.Domain.Models.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Required, StringLength(250)]
        public string FirstName { get; set; }
        [Required, StringLength(250)]
        public string LastName { get; set; }
    }
}

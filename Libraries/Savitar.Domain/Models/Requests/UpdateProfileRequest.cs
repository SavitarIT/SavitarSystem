using System;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Requests
{
    public class UpdateProfileRequest
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
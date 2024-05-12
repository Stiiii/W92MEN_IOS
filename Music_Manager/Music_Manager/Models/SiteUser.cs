using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Music_Manager.Models
{
    public class SiteUser : IdentityUser
    {
        [StringLength(200)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(200)]
        [Required]
        public string LastName { get; set; }

    }
}

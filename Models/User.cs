using Microsoft.AspNetCore.Identity;

namespace MEalAPI.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

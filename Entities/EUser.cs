using MEalAPI.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace MEalAPI.Entities
{
    public class EUser : IdentityUser, IUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

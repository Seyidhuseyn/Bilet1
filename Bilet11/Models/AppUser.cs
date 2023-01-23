using Microsoft.AspNetCore.Identity;

namespace Bilet11.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

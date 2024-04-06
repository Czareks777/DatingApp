using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public AppUsers User { get; set; }
        public AppRole Role { get; set; }
    }
}
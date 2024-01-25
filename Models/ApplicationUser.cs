using Microsoft.AspNetCore.Identity;

namespace CRUD_Operations.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

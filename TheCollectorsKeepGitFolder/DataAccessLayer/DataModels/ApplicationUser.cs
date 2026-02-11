using System.Diagnostics;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.DataModels
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Wishlist> Wishlists { get; set; }
            = new List<Wishlist>();

        public ICollection<Address> Addresses { get; set; }
            = new List<Address>();

        public ICollection<Order> Orders { get; set; }
            = new List<Order>();
    }
}

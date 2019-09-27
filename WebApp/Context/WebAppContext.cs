using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context
{
    public class WebAppContext : IdentityDbContext<ApplicationUser>
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Payment2> Payments { get; set; }

        public DbSet<PaymentList> PaymentLists { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalRChat.Models;

namespace SignalRChat.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RazorIdentityDemorender2web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // Aqui se agregan los DbSet para las entidades de la aplicación
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}

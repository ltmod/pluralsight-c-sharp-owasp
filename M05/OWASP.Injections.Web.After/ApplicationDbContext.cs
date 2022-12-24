using Microsoft.EntityFrameworkCore;
using OWASP.Injections.Web.After.Entities;

namespace OWASP.Injections.Web.After
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SensitiveUserDatum> SensitiveUserData { get; set; } = null!;
        public virtual DbSet<UserDatum> UserData { get; set; } = null!;
    }
}
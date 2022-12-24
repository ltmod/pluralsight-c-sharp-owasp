using Microsoft.EntityFrameworkCore;
using OWASP.Injections.Web.Before.Entities;

namespace OWASP.Injections.Web.Before
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
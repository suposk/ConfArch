using ConfArch.IdentityProvider.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConfArch.Web.Data
{
    public class ConfArchWebContext : IdentityDbContext<ApplicationUser>
    {
        public ConfArchWebContext(DbContextOptions<ConfArchWebContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //SQL Server
                //optionsBuilder.UseSqlServer(Constant.SqlServerConnectionString);
                //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlServerConnString"));

                optionsBuilder.UseNpgsql("Host=localhost;Database=ChurchDB;Username=postgres;Password=Password1");
            }
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

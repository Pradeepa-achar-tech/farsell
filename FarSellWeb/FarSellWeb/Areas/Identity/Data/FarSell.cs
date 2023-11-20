using FarSellWeb.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarSellWeb.Areas.Identity.Data;

public class FarSell : IdentityDbContext<FarSellWebUser>
{
    public FarSell(DbContextOptions<FarSell> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<FarSellWebUser>
{
    public void Configure(EntityTypeBuilder<FarSellWebUser> builder)
    {
        builder.Property(x => x.Firstname).HasMaxLength(100);
        builder.Property(x => x.Lastname).HasMaxLength(100);

    }
}

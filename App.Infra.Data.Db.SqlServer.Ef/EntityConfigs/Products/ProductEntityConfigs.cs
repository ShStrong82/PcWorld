using App.Domain.Core.Products.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Principal;

namespace App.Infra.Data.Db.SqlServer.Ef.EntityConfigs.Products;

public class ProductEntityConfigs : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products", "dbo");


        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500);
        builder.Property(x => x.Description).HasMaxLength(4000);
    }
}

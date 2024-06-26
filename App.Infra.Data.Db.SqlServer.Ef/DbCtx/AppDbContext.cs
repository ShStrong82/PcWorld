﻿using App.Domain.Core.Products.Entities;
using App.Infra.Data.Db.SqlServer.Ef.EntityConfigs.Products;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace App.Infra.Data.Db.SqlServer.Ef.DbCtx;

public class AppDbContext : IdentityDbContext<User, Role, int>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.ApplyConfiguration(new ProductEntityConfigs());
        //modelBuilder.ApplyConfiguration(new ProductCategoryEntityConfigs());
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        modelBuilder.Entity<Product>().HasQueryFilter(a => !a.IsDeleted);
    }
}



public class User : IdentityUser<int> 
{ 
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


public class Role : IdentityRole<int>
{
    public string NameFa { get; set; }
}
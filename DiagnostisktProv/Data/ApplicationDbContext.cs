using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DiagnostisktProv.Models;

namespace DiagnostisktProv.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
             .HasKey(di => di.ProductID);

            builder.Entity<ProductCategory>()
            .HasKey(di => di.CategoryID);

            builder.Entity<Product>()
            .HasOne(d => d.Category)
            .WithMany(d => d.Products)
            .HasForeignKey(d => d.CategoryID);

            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}

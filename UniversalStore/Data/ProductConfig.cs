using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalStore.Models;

namespace UniversalStore.Data
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(p => p.Id).IsUnique();

            builder.HasData
                (
                    new Product { Id = 1, Description = "256GB Black LLA", Name = "IPhone 16", Price = 899 },
                    new Product { Id = 2, Description = "128GB White LLA", Name = "IPhone 16E", Price = 699 },
                    new Product { Id = 3, Description = "512GB Blue LLA", Name = "IPhone 16 Pro max", Price = 1299 }
                );
        }
    }
}

﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class CategoryConfiguration : BaseConfiguration<CategoryEntity>
    {
        public override void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {

            builder.Property(x => x.Name)
                .HasMaxLength(40);

            builder.Property(x => x.Description)
                .IsRequired(false);

            base.Configure(builder);
        }
    }
}
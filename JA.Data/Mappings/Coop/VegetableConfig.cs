﻿using System.Data.Entity.ModelConfiguration;
using JA.Models.BlogModels.Food;

namespace JA.Data.Mappings.Coop
{
    // This is Table-Per-Type Inheritance TPT
    // So we are mapping each table to its own table
    // In this case we are not mapping the Base Class of Food
    // Only Map the inherited class of Vegetable
    public class VegetableConfig : EntityTypeConfiguration<Vegetable>
    {
        public VegetableConfig()
        {

            HasKey(k => k.Id);

            Property(p => p.Name).
                IsRequired().
                HasMaxLength(25);


            HasMany(f => f.VegiSubstitutions);

            Property(p => p.PricePerEach).HasPrecision(5, 2).IsOptional();
            Property(p => p.PricePerFlat).HasPrecision(5, 2).IsOptional();
            Property(p => p.PricePerPound).HasPrecision(5, 2).IsOptional();

            Map<Vegetable>(m => m.ToTable("Vegetables"));

        }

    }
}

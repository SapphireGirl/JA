﻿using System.Data.Entity.ModelConfiguration;
using JA.Models.BlogModels.Food;

namespace JA.Data.Mappings.Coop
{
    public class FruitConfig : EntityTypeConfiguration<Fruit>
    {
        // This is Table-Per-Type Inheritance TPT
        // So we are mapping each table to its own table
        // In this case we are not mapping the Base Class of Food
        // Only Map the inherited class of Vegetable
        public FruitConfig()
        {

            HasKey(k => k.Id);

            Property(p => p.Name).
                IsRequired().
                HasMaxLength(25);


            HasMany(f => f.FruitSubstitutions);

            Property(p => p.PricePerEach).HasPrecision(5, 2).IsOptional();
            Property(p => p.PricePerFlat).HasPrecision(5, 2).IsOptional();
            Property(p => p.PricePerPound).HasPrecision(5, 2).IsOptional();

            Map<Fruit>(m => m.ToTable("Fruits"));
        }
    }
}

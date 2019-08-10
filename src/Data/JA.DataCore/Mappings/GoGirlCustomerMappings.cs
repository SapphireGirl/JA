using System;
using System.Collections.Generic;
using System.Text;
using JA.ModelsCore.Customer;
using JA.ModelsCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JA.ModelsCore;

namespace JA.DataCore.Mappings
{
    public class GoGirlCustomerMappings : IEntityTypeConfiguration<GoGirlCustomer>
    {
       
        public void Configure(EntityTypeBuilder<GoGirlCustomer> modelBuilder)
        {

            //modelBuilder.Entity<Blog>(entity => {
            //    entity.HasIndex(c => c.ScormHost);
            //    entity.Property(e => e.ScormHost).HasMaxLength(240);
            //    entity.Property(e => e.Created).IsRequired();
            //    entity.Property(e => e.Title).IsRequired();
            //});

            //modelBuilder.Entity<GoGirlCustomer>(entity => {
            //    entity.Property(e => e.CompanyId).IsRequired();
            //    entity.Property(e => e.ParentId).HasDefaultValue(0);
            //    entity.Property(e => e.Title).IsRequired();
            //    entity.HasOne(d => d.Company).WithMany(p => p.CompanyDepartments).HasForeignKey(d => d.CompanyId);
            //    entity.HasOne(d => d.Parent).WithMany(p => p.Items).HasForeignKey(d => d.ParentId);
            //});

            //builder.Property(c => c.Name).HasMaxLength(200);


            modelBuilder.HasKey(x => x.Id);
            // buimodelBuilderlder.HasOne(e => e.Details).WithOne(o => o.Product).HasForeignKey<ProductDetail>(e => e.ProductID);
            modelBuilder.Property(x => x.FirstName).HasColumnName("FirstName");
            // builder.HasQueryFilter(o => o.Cost > 0);
            modelBuilder.ToTable("Product");


            //modelBuilder.HasKey<int>(s => s.Id);
            //    modelBuilder.Property(p => p.DateOfBirth)
            //    modelBuilder.HasColumnName("DoB")
            //    modelBuilder.HasColumnOrder(3)
            //    modelBuilder.HasColumnType("datetime2");

            //this.Property(p => p.FirstName)
            //    .HasMaxLength(50);
            //this.Property(p => p.LastName)
            //    .IsConcurrencyToken();
            ////this.Property(p => p.CustomerAddress)
            ////    .HasMaxLength(50);
            //this.Property(p => p.Email)
            //    .HasMaxLength(50);
            //this.Property(p => p.PoliticalAffilliation)
            //    .HasMaxLength(50);
            //this.HasMany<FoodLog>(s => s.Foodlogs);
            // .WithMany(c => c.Food)
            //.Map(cs =>
            //{
            //    cs.MapLeftKey("StudentId");
            //    cs.MapRightKey("CourseId");
            //    cs.ToTable("StudentCourse");
            //});
        }
    }
}

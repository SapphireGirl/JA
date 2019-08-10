using System.Data.Entity.ModelConfiguration;
using JA.Models.BlogModels.Food;
using JA.Models.CustomerModels;

namespace JA.Data.Mappings.GoGirl
{
    public class GoGirlCustomerMappings:  EntityTypeConfiguration<GoGirlCustomer>
    {
        public GoGirlCustomerMappings()
        {
            this.ToTable("Customer");

            this.HasKey<int>(s => s.Id);

            this.Property(p => p.DateOfBirth)
                .HasColumnName("DoB")
                .HasColumnOrder(3)
                .HasColumnType("datetime2");

            this.Property(p => p.FirstName)
                .HasMaxLength(50);
            this.Property(p => p.LastName)
                .IsConcurrencyToken();
            //this.Property(p => p.CustomerAddress)
            //    .HasMaxLength(50);
            this.Property(p => p.Email)
                .HasMaxLength(50);
            this.Property(p => p.PoliticalAffilliation)
                .HasMaxLength(50);
            //this.HasMany<Foodlog>(s => s.Foodlogs);
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

using System.Data.Entity.ModelConfiguration;
using JA.Models.BlogModels.BI;
using JA.Models.BlogModels.Food;

namespace JA.Data.Mappings
{
    public class GoGirlCustomerMappings:  EntityTypeConfiguration<GoGirlCustomer>
    {
        public GoGirlCustomerMappings()
        {
            this.ToTable("GoGirlCustomer");

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
            this.HasMany<Foodlog>(s => s.Foodlogs);
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

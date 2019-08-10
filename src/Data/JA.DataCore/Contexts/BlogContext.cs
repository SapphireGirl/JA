using JA.DataCore.Mappings;
using JA.ModelsCore.Blog;
using JA.ModelsCore.Blog.Food;
using JA.ModelsCore.Blog.WO;
using JA.ModelsCore.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;

namespace JA.DataCore
{
    public class BlogContext : ContextBase<BlogContext>
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public virtual DbSet<BlogPost> Blogs { get; set; }
        public virtual DbSet<GoGirlCustomer> Customers { get; set; }

        public virtual DbSet<WorkoutLog> WorkoutLogs { get; set; }
        public virtual DbSet<FoodLog> Foodlogs { get; set; }
       // public virtual DbSet<BlogPost> Blogs { get; set; }

        //public virtual DbSet<Companies> Companies { get; set; }
        //public virtual DbSet<CompanyDepartments> CompanyDepartments { get; set; }
        //public virtual DbSet<CompanyLicences> CompanyLicences { get; set; }
        //public virtual DbSet<CompanyUsers> CompanyUsers { get; set; }
        //public virtual DbSet<CourseDatas> CourseDatas { get; set; }
        //public virtual DbSet<CourseUsers> CourseUsers { get; set; }
        //public virtual DbSet<LANGMasterScorms> LANGMasterScorms { get; set; }
        //public virtual DbSet<UserLicences> UserLicences { get; set; }
        //public virtual DbSet<Users> Users { get; set; }
        //private string myConnectionString = String.Empty;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.HasDefaultSchema("Production");
           // modelBuilder.HasChangeTrackingStrategy()
           // modelBuilder.ApplyConfiguration(new GoGirlCustomerMappings());
            modelBuilder.Entity<GoGirlCustomer>(entity => {
              //  entity.HasIndex(e => new { e.LicenceId, e.Counter }).IsUnique();
                entity.HasIndex(n => n.LastName);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(p => p.PoliticalAffilliation);
                entity.Property(e => e.DateOfBirth).IsRequired();
                entity.Property(e => e.DateCreated).IsRequired();

                entity.Property(e => e.DateModified).IsRequired();

                //entity.HasOne(d => d.CustomerAddress).WithOne(a => a.Region).IsRequired();
                    
                 //   WithMany(p => p.UserLicences).HasForeignKey(d => d.LicenceId);
                //entity.HasOne(d => d.CourseUser).WithMany(p => p.UserLicences).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.Property(n => n.BlogJson);
                entity.Property(e => e.Title).IsRequired();
                
            });

            modelBuilder.Entity<FoodLog>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.Property(n => n.DateCreated).IsRequired();
                entity.Property(e => e.DateModified);
                //entity.HasMany<Food>(p => p.Food).HasForeignKey(d => d.FoodLogId);
                // entity.Property(p => p.IsDirty).Ignore();

            });



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //var config = ConfigurationManager<>.ConnectionStrings["Container"];
            //var conn = new SqlConnection(config.ConnectionString);

            //optionsBuilder.EnableSensitiveDataLogging()
            //    .UseLazyLoadingProxies()
            //    .UseSqlServer(myConnectionString);
        }
    }
}

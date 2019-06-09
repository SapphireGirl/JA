using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using JA.Models.BlogModels.BI;
using JA.Models.BlogModels.Food;
using JA.Models.BlogModels.WO;
using JA.Models.SharedModels;

namespace JA.Data.Context
{
    public class BlogContext : DbContext
    {

        public DbSet<GoGirlCustomer> GoGirls { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<IWorkout> Workouts { get; set; }
        public DbSet<WorkoutLog> WorkoutLogs { get; set; }
        public DbSet<Foodlog> Foodlogs { get; set; }
        // public DbSet<BlogUser> Users { get; set; }
        //private string connectionString;
        //protected SqlConnectionStringBuilder builder { get; set; }
        //

        public BlogContext()
        {
            // BlogConnection
        }

        // ToDo: Complete Mappings
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Types()
                    .Configure(c => c.Ignore("IsDirty"));
                base.OnModelCreating(modelBuilder);

                // mapping for gogirlcustomer
                //modelBuilder.Configurations

                //HasKey(x => x.Id);
                //HasRequired<Candidate>(s => s.Candidate)
                //    .WithMany(s => s.Qualifications)
                //    .HasForeignKey(s => s.CandidateId);

        }

        /// <summary>
        /// Force Entity Framework to update the modification history
        /// as necessary when we call SaveChanges.
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            foreach (var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory && (e.State == EntityState.Added ||
                                                                 e.State == EntityState.Modified))
                .Select(e => e.Entity as IModificationHistory)
            )
            {
                history.DateModified = DateTime.Now;
                if (history.DateCreated == DateTime.MinValue)
                {
                    history.DateCreated = DateTime.Now;
                }
            }
            int result = base.SaveChanges();
            foreach (var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory)
                .Select(e => e.Entity as IModificationHistory)
            )
            {
                history.IsDirty = false;
            }
            return result;
        }
    }
}

using System.Data.Entity;
using System.Data.SqlClient;

namespace JA.Data.Context
{
    public class BlogContext : DbContext
    {
       
            //public DbSet<GoGirlCustomer> GoGirls { get; set; }
            //public DbSet<IFood> Food { get; set; }
            //public DbSet<IWorkout> Workouts { get; set; }
            //public DbSet<WorkoutLog> WorkoutLogs { get; set; }
            //public DbSet<Foodlog> Foodlogs { get; set; }
            //public DbSet<BlogUser> Users { get; set; }


            private string connectionString;
            protected SqlConnectionStringBuilder builder { get; set; }
    }
}

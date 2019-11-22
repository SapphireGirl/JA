using JA.ModelsCore.Customer;
using Microsoft.EntityFrameworkCore;

namespace JA.DataCore
{
    public class ContextBase<Entity> : DbContext where Entity : class
    {
        private DbContextOptions<BlogContext> _options;

        protected DbContextOptionsBuilder _OptionsBuilder;
        public ContextBase(DbContextOptions<BlogContext> options)
        {
            _options = options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Entity>().HasKey(x => x.Id);
            
        }
    }
}
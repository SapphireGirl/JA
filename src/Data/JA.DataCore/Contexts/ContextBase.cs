using JA.ModelsCore.Customer;
using Microsoft.EntityFrameworkCore;

namespace JA.DataCore
{
    public class ContextBase<Entity> : DbContext
    {
        private DbContextOptions<BlogContext> _options;
        public ContextBase(DbContextOptions<BlogContext> options)
        {
            _options = options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GoGirlCustomer>()
                // .HasAlternateKey(x => x.Identity);
                .HasKey(x => x.Id);

            //modelBuilder.Entity<BreakoutSessionTag>()
            //    .HasKey(x => new { x.BreakoutSessionId, x.TagId });
        }
    }
}
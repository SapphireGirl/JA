using System.Data.Entity;
using JA.Data.Context;

namespace JA.Data.Mappings.Tasks
{
    public class UserConfig
    {
        public OrderContext _taskContext { get; private set; }
        public UserConfig(OrderContext context)
        {
            _taskContext = context;
        }

        protected virtual void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}

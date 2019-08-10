using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JA.Data.Context;
using JA.Models.CustomerModels;

namespace JA.Data.Repositories
{
    public class BlogRepositories
    {
        public BlogContext _dbContext { get; }

        public BlogRepositories(BlogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ILookup<int, GoGirlCustomer>> GetGoGirlCustomers(IEnumerable<int> ids)
        {
            var customers = await _dbContext.Customers.Where(cust => ids.Contains(cust.Id)).ToListAsync();
            return customers.ToLookup(c => c.Id);
        }

    }
}

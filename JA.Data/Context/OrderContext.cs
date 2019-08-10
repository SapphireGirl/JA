using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JA.Models.CustomerModels;
using JA.Models.OrderModels;

namespace JA.Data.Context
{
    public class OrderContext : BaseContext<OrderContext>
    {
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<GoGirlCustomer> Customers { get; set; }
       // public DbSet<Project> Projects { get; set; }


    }
}

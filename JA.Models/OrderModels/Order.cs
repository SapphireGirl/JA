using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JA.Models.CustomerModels;
using JA.Models.ProductModels;

namespace JA.Models.OrderModels
{
    public class Order : Entity<Order>, IOrder 
    {
        public DateTime orderDate { get; set; }
        public DateTime sentDate { get; set; }
        public DateTime receivedDate { get; set; }
        public GoGirlCustomer customer { get; set; }


    }

    public interface IOrder
    {
    }
}

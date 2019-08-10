using System;
using System.Collections.Generic;
using System.Text;
using JA.ModelsCore.Customer;

namespace JA.ModelsCore.Order
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using JA.Models.CustomerModels;
using JA.Models.OrderModels;

namespace JA.Models.ProductModels
{
    public class Product : Entity<Product>, IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        // All product pages have category tags
        private List<Tag> _tags = new List<Tag>();
        public IEnumerable<Tag> Tags => _tags;

        // list of all who bought for reporting
        private List<GoGirlCustomer> _customers = new List<GoGirlCustomer>();

        public IEnumerable<GoGirlCustomer> Customers => _customers;

        private List<Order> _onOrders = new List<Order>();

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        
    }

    public interface IProduct
    {
    }
}

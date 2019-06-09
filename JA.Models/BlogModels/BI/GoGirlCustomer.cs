using System;
using System.Collections.Generic;
using System.Linq;
using JA.Models.BlogModels.Food;
using JA.Models.SharedModels;

namespace JA.Models.BlogModels.BI
{
    public class GoGirlCustomer : IGoGirlCustomer, IModificationHistory
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address CustomerAddress { get; set; }

        public string Email { get; set; }
        public string PoliticalAffilliation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
        public ICollection<Foodlog> Foodlogs { get; set; }

        public GoGirlCustomer()
        {
            CustomerAddress = new Address();
        }
    }
}

using System;
using JA.Models.SharedModels;

namespace JA.Models.CustomerModels
{
    public class User //: GoGirlCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address CustomerAddress { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string PoliticalAffilliation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }

       // public virtual ICollection<Project> Courses { get; private set; }
    }
}

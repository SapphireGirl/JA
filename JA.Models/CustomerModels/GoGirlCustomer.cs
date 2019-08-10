using System;
using System.Collections.Generic;
using JA.Models.BlogModels;
using JA.Models.BlogModels.Food;
using JA.Models.BlogModels.WO;
using JA.Models.SharedModels;

namespace JA.Models.CustomerModels
{
    public class GoGirlCustomer : Entity<GoGirlCustomer>, IGoGirlCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address CustomerAddress { get; set; }

        public string Email { get; set; }
        public string PoliticalAffilliation { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Foodlog> Foodlogs { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<WorkoutLog> Workouts { get; set; }

        public GoGirlCustomer()
        {
            CustomerAddress = new Address();
        }

        public IDisposable Subscribe(IObserver<GoGirlCustomer> observer)
        {
            throw new NotImplementedException();
        }

        // IModification
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}

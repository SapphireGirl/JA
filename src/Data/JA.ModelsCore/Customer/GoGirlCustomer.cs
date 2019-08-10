using System;
using System.Collections.Generic;
using System.Text;
using JA.ModelsCore.Blog.Food;
using JA.ModelsCore.Blog.WO;
using JA.ModelsCore.Shared;

namespace JA.ModelsCore.Customer
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

        public ICollection<FoodLog> Foodlogs { get; set; }
        public ICollection<Blog.BlogPost> Blogs { get; set; }
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

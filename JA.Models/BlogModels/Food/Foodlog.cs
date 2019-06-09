using System;
using System.Collections.Generic;
using System.Linq;
using JA.Models.SharedModels;

namespace JA.Models.BlogModels.Food
{
    public class Foodlog : BlogTime, IModificationHistory
    {
        public int Id { get; set; }
        public ICollection<Food> Food { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}

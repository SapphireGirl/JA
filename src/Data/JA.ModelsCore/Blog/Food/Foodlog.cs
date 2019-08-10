using System;
using System.Collections.Generic;
using JA.ModelsCore.Shared;

namespace JA.ModelsCore.Blog.Food
{
    public class FoodLog : BlogBase, IModificationHistory
    {
        public int Id { get; set; }
        public ICollection<Food> Food { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}

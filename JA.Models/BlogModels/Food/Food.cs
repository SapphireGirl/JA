using System;
using JA.Models.SharedModels;

namespace JA.Models.BlogModels.Food
{
    public class Food : BlogBase, IModificationHistory
    {
        public int Id { get; set; }

        private string _Name;
        public string Name
        {
            get
            {
                if (IsVegi)
                {
                    _Name = Vegi.Name;
                    return Vegi.Name;
                }

                return Name;
            }
            set { _Name = value; }
        }

        public string Amount;
        public string CookingMethod;

        public Vegetable Vegi { get; set; }
        public Fruit Fruit { get; set; }

        public bool IsVegi { get; set; }
        public bool IsFruit { get; set; }

        public DateTime Time { get; set; }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
        
    }
}
using System;
using JA.ModelsCore.Shared;

namespace JA.ModelsCore.Blog.Food
{
    public abstract class Produce : BlogBase, IObjectWithState, IModificationHistory
    {

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public decimal? PricePerEach { get; set; }
        public decimal? PricePerFlat { get; set; }
        public decimal? PricePerPound { get; set; }

        public State State { get; set; }

        public Produce()
        {

        }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }


        public override string TimeRecorded(int GoGirlCustomerId)
        {
            throw new NotImplementedException();
        }

        public override string MealRecorded(int GoGirlCustomerId)
        {
            throw new NotImplementedException();
        }

        public override string PostRecorded(int GoGirlCustomerId)
        {
            throw new NotImplementedException();
        }

        public override string CommentRecorded(int GoGirlCustomerId)
        {
            throw new NotImplementedException();
        }

        public override string BlogPostRecorded(int GoGirlCustomerId)
        {
            throw new NotImplementedException();
        }
    }
}

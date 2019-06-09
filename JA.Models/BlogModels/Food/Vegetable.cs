using System.Collections.Generic;
using JA.Models.SharedModels;

namespace JA.Models.BlogModels.Food
{
    public class Vegetable : Produce
    {


        public virtual ICollection<Vegetable> VegiSubstitutions { get; set; }

        //  public State State { get; set; }

        public Vegetable()
        {

        }

    }
}

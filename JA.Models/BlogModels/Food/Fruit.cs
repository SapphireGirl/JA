using System;
using System.Collections.Generic;
using JA.Models.SharedModels;

namespace JA.Models.BlogModels.Food
{
    public class Fruit : Produce
    {

        public virtual ICollection<Fruit> FruitSubstitutions { get; set; }

        // public State State { get; set; }

        public Fruit()
        {

        }
    }
}

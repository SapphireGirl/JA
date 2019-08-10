using System.Collections.Generic;

namespace JA.ModelsCore.Blog.Food
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

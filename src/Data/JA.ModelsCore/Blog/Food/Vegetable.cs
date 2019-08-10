using System.Collections.Generic;

namespace JA.ModelsCore.Blog.Food
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JA.Models.BlogModels.Food;
using JA.Models.ProductModels;

namespace JA.Models.BlogModels
{
    public class Blog : BlogBase, IBlog
    {
        public string Title { get; set; } 
        public string BlogJson { get; set;  }
    }

    public interface IBlog
    {
    }
}

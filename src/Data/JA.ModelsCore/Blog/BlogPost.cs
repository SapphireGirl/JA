using System;
using System.Collections.Generic;
using System.Text;

namespace JA.ModelsCore.Blog
{
    public class BlogPost : BlogBase, IBlogPost
    {
        public string Title { get; set; }
        public string BlogJson { get; set; }
    }

    public interface IBlogPost
    {
    }
}

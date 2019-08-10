using System;
using System.Collections.Generic;
using System.Text;

namespace JA.ModelsCore.Blog
{
    public class BlogBase : Entity<BlogBase>
    {
        public virtual string TimeRecorded(int GoGirlCustomerId)
        {
            return DateTime.Now.ToShortTimeString();
        }

        public virtual string MealRecorded(int GoGirlCustomerId)
        {
            return DateTime.Now.ToShortTimeString();
        }

        public virtual string PostRecorded(int GoGirlCustomerId)
        {
            return DateTime.Now.ToShortTimeString();
        }

        public virtual string CommentRecorded(int GoGirlCustomerId)
        {
            return DateTime.Now.ToShortTimeString();
        }

        public virtual string BlogPostRecorded(int GoGirlCustomerId)
        {
            return DateTime.Now.ToShortTimeString();
        }

    }
}

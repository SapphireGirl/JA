using System;

namespace JA.Models.BlogModels.Food
{
    public class BlogTime
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
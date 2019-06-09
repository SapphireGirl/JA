using System;
using JA.Models.SharedModels;

namespace JA.Models.BlogModels.WO
{
    public class WorkoutLog : IModificationHistory
    {
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}

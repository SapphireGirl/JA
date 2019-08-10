using System;
using JA.Models.SharedModels;

namespace JA.Models.BlogModels.WO
{
    public class WorkoutLog : Entity<WorkoutLog>, IWorkoutLog
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}

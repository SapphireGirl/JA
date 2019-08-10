using System;
using System.Collections.Generic;
using System.Text;

namespace JA.ModelsCore.Blog.WO
{
    public class WorkoutLog : Entity<WorkoutLog>, IWorkoutLog
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public ICollection<Workout> Workouts { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }

    public interface IWorkoutLog
    {

    }
}

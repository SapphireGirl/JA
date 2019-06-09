namespace JA.Models.BlogModels.WO
{
    public class WOPartner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public WorkoutLevel Level { get; set; }

    }

    public enum WorkoutLevel { Beginning, Intermediate, Advanced };
    public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
}

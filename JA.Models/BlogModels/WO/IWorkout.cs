namespace JA.Models.BlogModels.WO
{
    public interface IWorkout
    {
        string TimeRecorded(int GoGirlCustomerId);
        string WorkOutRecorded(int GoGirlCustomerId);
        string CommentRecorded(int GoGirlCustomerId);
        string BlogPostRecorded(int GoGirlCustomerId);
    }
}

namespace JA.Models.SharedModels
{
    public interface IObjectWithState
    {
        State State { get; set; }
    }



    public enum State
    {
        Added,
        Unchanged,
        Modified,
        Deleted
    }
}

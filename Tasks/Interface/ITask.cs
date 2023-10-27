namespace Tasks
{
    public interface ITask
    {
        string Description { get; }
        object Solve(params object[] parameters);
    }
}

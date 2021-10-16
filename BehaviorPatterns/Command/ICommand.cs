namespace BehaviorPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

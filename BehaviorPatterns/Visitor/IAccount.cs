namespace BehaviorPatterns.Visitor
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}

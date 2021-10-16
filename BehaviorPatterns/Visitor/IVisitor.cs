namespace BehaviorPatterns.Visitor
{
    public interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAc(Company acc);
    }
}

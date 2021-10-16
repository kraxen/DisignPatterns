namespace SOLID.Single_Responsibility_Principle.Example1
{
    public interface IPageNavigation
    {
        void GoToFirstPage();
        void GoToLastPage();
        void GoToPage(int pageNumber);
    }
}
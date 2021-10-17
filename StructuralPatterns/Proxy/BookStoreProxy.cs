using System.Collections.Generic;
using System.Linq;

namespace StructuralPatterns.Proxy
{

    public class BookStoreProxy : IBook
    {
        List<Page> pages;
        BookStore bookStore;
        public BookStoreProxy()
        {
            pages = new List<Page>();
        }
        public Page GetPage(int number)
        {
            Page page = pages.FirstOrDefault(p => p?.Number == number);
            if (page == null)
            {
                if (bookStore == null)
                    bookStore = new BookStore();
                page = bookStore.GetPage(number);
                pages.Add(page);
            }
            return page;
        }
        public void AddPages(List<Page> pagesList)
        {
            pages.AddRange(pagesList);
        }
        public void SaveChanges()
        {
            if (bookStore != null)
                bookStore.SaveChanges();
        }
        public void Dispose()
        {
            if (bookStore != null)
                bookStore.Dispose();
        }
    }
}

using StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsStart.StructuralPatterns
{
    class Proxy : IPattern
    {
        public void Start()
        {
            using (IBook book = new BookStoreProxy())
            {
                if(book.GetPage(1) == null)
                {
                    book.AddPages(new List<Page>{
                    new Page { Id = 1, Number = 1, Text = "Page 1 text."},
                    new Page { Id = 2, Number = 2, Text = "Page 2 text." },
                    new Page { Id = 3, Number = 3, Text = "Page 3 text." }
                });
                }
                book.SaveChanges();
                // читаем первую страницу
                Page page1 = book.GetPage(1);
                Console.WriteLine(page1?.Text);
                // читаем вторую страницу
                Page page2 = book.GetPage(2);
                Console.WriteLine(page2?.Text);
                // возвращаемся на первую страницу    
                page1 = book.GetPage(3);
                Console.WriteLine(page1?.Text);
            }
        }
    }
}

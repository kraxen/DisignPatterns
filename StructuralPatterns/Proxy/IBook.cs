using System;
using System.Collections.Generic;

namespace StructuralPatterns.Proxy
{
    public interface IBook : IDisposable
    {
        Page GetPage(int number);
        public void AddPages(List<Page> pagesList);
        public void SaveChanges();
    }
}

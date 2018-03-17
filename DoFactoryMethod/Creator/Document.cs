using System.Collections.Generic;

using DoFactoryMethod.AbstractProduct;

namespace DoFactoryMethod.Creator
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages => _pages;

        // Factory Method

        public abstract void CreatePages();
    }
}

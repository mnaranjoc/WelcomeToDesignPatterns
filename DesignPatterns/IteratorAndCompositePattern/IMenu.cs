using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern
{
    public interface IMenu
    {
        void addItem(string name, string description, bool vegetarian, double price);
        Iterator createIterator();
    }
}

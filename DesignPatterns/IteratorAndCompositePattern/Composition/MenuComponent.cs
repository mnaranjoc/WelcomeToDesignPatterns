using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern.Composition
{
    public abstract class MenuComponent
    {
        public void add(MenuComponent menuComponent)
        {
            throw new NotSupportedException("");
        }

        public void remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException("");
        }

        public MenuComponent getChild(int i)
        {
            throw new NotSupportedException("");
        }

        public virtual string getName()
        {
            throw new NotSupportedException("");
        }

        public virtual string getDescription()
        {
            throw new NotSupportedException("");
        }

        public virtual double getPrice()
        {
            throw new NotSupportedException("");
        }

        public virtual bool isVegetarian()
        {
            throw new NotSupportedException("");
        }

        public virtual void print()
        {
            throw new NotSupportedException("");
        }
    }
}

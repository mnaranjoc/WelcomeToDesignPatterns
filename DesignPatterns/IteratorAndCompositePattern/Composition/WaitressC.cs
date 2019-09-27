using System;
using System.Collections;

namespace IteratorAndCompositePattern.Composition
{
    class WaitressC
    {
        MenuComponent allMenus;

        public WaitressC(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            allMenus.print();
        }
    }
}

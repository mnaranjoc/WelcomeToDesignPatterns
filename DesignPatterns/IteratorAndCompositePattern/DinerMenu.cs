using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern
{
    class DinerMenu : IMenu
    {
        public static int MAX_ITEMS = 6;
        int numOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            addItem("Vegetarian BLT",
                    "Fake Bacon with Lettuce and tomatoe on whole wheat",
                    true,
                    2.99);

            addItem("BLT",
                    "Bacon with Lettuce and tomatoe on whole wheat",
                    false,
                    2.99);

            addItem("Soup of the day",
                    "Soup of the day with a side of potatoe salad",
                    false,
                    3.29);

            addItem("Hotdog",
                    "A hot dog with saurkrart relish onions topped with cheese",
                    false,
                    3.05);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            
            if (numOfItems >= MAX_ITEMS)
                Console.WriteLine("Menu is full!");
            else
            {
                menuItems[numOfItems] = menuItem;
                numOfItems++;
            }
        }

        /*public MenuItem[] getMenuItems()
        {
            return menuItems;
        }*/
        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}

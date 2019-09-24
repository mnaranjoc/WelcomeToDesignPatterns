using System;

namespace IteratorAndCompositePattern.Composition
{
    class DinerMenuC : IMenuC
    {
        public static int MAX_ITEMS = 6;
        int numOfItems = 0;
        MenuItemC[] menuItems;

        public DinerMenuC()
        {
            menuItems = new MenuItemC[MAX_ITEMS];

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
            MenuItemC menuItem = new MenuItemC(name, description, vegetarian, price);

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
        public IteratorC createIterator()
        {
            return new DinerMenuIteratorC(menuItems);
        }
    }
}

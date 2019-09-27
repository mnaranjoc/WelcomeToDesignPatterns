using IteratorAndCompositePattern.Composition;
using IteratorAndCompositePattern.Iterator;
using System;
using System.Collections;

namespace IteratorAndCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.IteratorExcercise();
            Program.CompositionExcercise();

            Console.ReadLine();
        }

        public static void CompositionExcercise()
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "BREAKFAST");
            MenuComponent dinerMenu = new Menu("DINER MENU", "LUNCH");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "DINNER");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "DESSERT OF COURSE!");

            MenuComponent allMenus = new Menu("ALL MENUS", "ALL MENUS COMBINED");
            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);

            dinerMenu.add(new MenuItemC(
                "Pasta",
                "Spaguetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89));

            //Add more items here

            dinerMenu.add(dessertMenu);

            dessertMenu.add(new MenuItemC(
                "Apple pie",
                "Apple pie with a flakey crust, topped with vanilla icecream",
                true,
                1.59));

            //Add more items here

            WaitressC waitress = new WaitressC(allMenus);
            waitress.printMenu();
        }

        public static void IteratorExcercise()
        {
            ArrayList menus = new ArrayList();
            menus.Add(new DinerMenu());
            menus.Add(new PancakeHouseMenu());

            Waitress waitress = new Waitress(menus);
            waitress.printMenu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern.Composition
{
    class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override bool isVegetarian()
        {
            return vegetarian;
        }

        public override double getPrice()
        {
            return price;
        }

        public override void print()
        {
            string print = "";

            print += " " + getName();
            if (isVegetarian())
                print += "(v)";
            print += ", $" + getPrice();
            print += "   ~~" + getDescription();

            Console.WriteLine(print);
        }
    }
}

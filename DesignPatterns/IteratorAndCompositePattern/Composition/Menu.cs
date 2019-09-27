﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern.Composition
{
    class Menu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override void print()
        {
            string print = "";

            print += "\n " + getName();
            print += ", " + getDescription();
            print += "-----------------"; ;
            Console.WriteLine(print);

            IEnumerator enumerator= menuComponents.GetEnumerator();
            while(enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                menuComponent.print();

                // 370
            }
        }
    }
}

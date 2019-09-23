using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Template
{
    public abstract class CaffeineBeverage
    {
        void prepareReceipe()
        {
            boilWater();
            brew();
            pourInCoup();
            addCondiments();
        }

        public abstract void addCondiments();

        public void pourInCoup()
        {
            Console.WriteLine("Pouring into coup");
        }

        public abstract void brew();

        public void boilWater()
        {
            Console.WriteLine("Boiling condiments");
        }
    }
}

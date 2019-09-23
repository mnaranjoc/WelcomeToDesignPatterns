using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Template
{
    public abstract class CaffeineBeverage
    {
        public void prepareReceipe()
        {
            boilWater();
            brew();
            pourInCoup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }

        public virtual bool customerWantsCondiments()
        {
            return true;
        }

        public abstract void addCondiments();

        private void pourInCoup()
        {
            Console.WriteLine("Pouring into coup");
        }

        public abstract void brew();

        private void boilWater()
        {
            Console.WriteLine("Boiling condiments");
        }
    }
}

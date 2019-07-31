using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            // Make it double mocha
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            Console.WriteLine(string.Format("Beverage: {0}\nCost: {1}\n", beverage.getDescription(), beverage.cost()));

            Console.ReadLine();
        }
    }
}

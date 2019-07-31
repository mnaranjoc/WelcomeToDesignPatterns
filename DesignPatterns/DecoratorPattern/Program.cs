using DecoratorPattern.Beverage_example;
using DecoratorPattern.Sales_order_example;
using DecoratorPattern.Sales_Order_example;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beverage example
            Beverage beverage = new Espresso();
            // Make it double mocha
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            Console.WriteLine(string.Format("Beverage: {0}\nCost: {1}\n", beverage.getDescription(), beverage.cost()));

            // Sales order example
            BaseOrder baseOrder = new PreOrder();
            baseOrder = new PremiumRegularOrder(baseOrder);
            Console.WriteLine(string.Format("Order price is: {0}", baseOrder.CalculateTotalOrderPrice()));

            Console.ReadLine();
        }
    }
}
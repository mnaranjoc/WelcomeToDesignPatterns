using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Sales_Order_example;

namespace DecoratorPattern.Sales_order_example
{
    class PremiumRegularOrder : OrderDecorator
    {
        public PremiumRegularOrder(BaseOrder _baseOrder) : base(_baseOrder)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a premium order.");
            return baseOrder.CalculateTotalOrderPrice() * 0.8;
        }
    }
}

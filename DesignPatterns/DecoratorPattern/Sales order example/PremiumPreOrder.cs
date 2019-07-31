using DecoratorPattern.Sales_Order_example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sales_order_example
{
    class PremiumPreOrder : OrderDecorator
    {
        public PremiumPreOrder(BaseOrder _baseOrder) : base(_baseOrder)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a premium preorder.");
            return baseOrder.CalculateTotalOrderPrice() * 0.9;
        }
    }
}

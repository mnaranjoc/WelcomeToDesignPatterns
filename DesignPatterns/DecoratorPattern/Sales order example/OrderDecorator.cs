using DecoratorPattern.Sales_Order_example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sales_order_example
{
    class OrderDecorator : BaseOrder
    {
        public BaseOrder baseOrder;

        public OrderDecorator(BaseOrder _baseOrder)
        {
            baseOrder = _baseOrder;
        }

        public override double CalculateTotalOrderPrice()
        {
            return baseOrder.CalculateTotalOrderPrice();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public static class OrderStatusFactory
    {
        public static IOrderState Carate(OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.New:
                    return new OrderNewState();
                case OrderStatus.Shipped:
                    return new OrderShippedState();
                case OrderStatus.Canceled:
                    return new OrderCanceledState();
                default:
                    return null;
            }
        }
    }
}

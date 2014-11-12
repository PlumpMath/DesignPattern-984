using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public static class ShippingCourierFactory
    {
        public static IShippingCourier CreateShippingCourier(Order order)
        {
            if (order.WeightInKG>100)
            {
                return new STO();
            }
            else
            {
                return new YTO();
            }
        }
    }
}

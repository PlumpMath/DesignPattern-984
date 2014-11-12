using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class OrderService
    {
        public void Dispatch(Order order)
        {
            IShippingCourier shippingCourier = ShippingCourierFactory.CreateShippingCourier(order);
            order.CourierTrackId = shippingCourier.GetCourierTrackId(order.DispatchAddress);
            Console.WriteLine(order.CourierTrackId);
        }
    }
}

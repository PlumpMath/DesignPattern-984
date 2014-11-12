using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                CountryCode = "86"
            };
            Order order = new Order()
            {
                DispatchAddress = address,
                TotalCost = 20,
                WeightInKG = 101
            };
            OrderService orderService = new OrderService();
            orderService.Dispatch(order);
            Console.Read();
        }
    }
}

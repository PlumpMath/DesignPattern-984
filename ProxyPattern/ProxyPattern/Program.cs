using ProxyPattern.Model;
using ProxyPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    /* 
     * 背景
     * 使用代理模式实现延迟加载
     * 
     * 模式意图
     * Proxy模式充当另一个对象的代理人，使得代理能够控制对该对象的访问
     * 并且可以添加与该对象相关答得额外逻辑。
     * 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Guid customerId = Guid.NewGuid();

            IOrderRepository orderRepository = new OrderRepository();

            Customer customer = new CustomerProxy() { OrderRepository = orderRepository, Id = customerId };

            IEnumerable<Order> orders = customer.Orders;
        }
    }
}

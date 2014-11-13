using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /* 背景：
     * 假设一张订单在任意时刻出于3中状态之一：
     * New(新订单)、Shipped(已发货)和Canceled(已取消)
     * New状态的订单可以发货或被取消
     * Shipped和Canceled状态的订单不能被发货或取消
     * 
     * 模式意图：
     * State模式允许对象在其内部状态改变时改变自己的行为。
     * 这是通过切换实现状态依赖行为的内部状态对象来实现的。
     * 对象将所有基于状态的行为推给依赖的状态子类，这就减
     * 轻了在对象方法中对case语句的需求量
     */

    /// <summary>
    /// 订单状态
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IOrderState orderState = OrderStatusFactory.Carate(OrderStatus.New);
            Order order = new Order(orderState)
            {
                Id = 1,
                Customer = "zxj",
                OrderDate = DateTime.Now
            };
            Console.WriteLine("当前状态：{0}", order.Status());
            Console.WriteLine("状态改变：{0}",OrderStatus.Shipped);
            order.Ship();
            Console.WriteLine("当前状态：{0}", order.Status());
            order.Cancel();

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 订单已发货状态
    /// </summary>
    public class OrderShippedState:IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            Console.WriteLine("该订单已发货");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("你不能取消已发货的订单");
        }

        public OrderStatus Status
        {
            get { return OrderStatus.Shipped; }
        }

    }
}

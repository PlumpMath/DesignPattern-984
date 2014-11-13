using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 取消订单
    /// </summary>
    public class OrderCanceledState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            Console.WriteLine("你不能为一张取消订单发货");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("该订单已取消");
        }

        public OrderStatus Status
        {
            get { return OrderStatus.Canceled; }
        }
    }
}

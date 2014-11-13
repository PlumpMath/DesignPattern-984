using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public interface IOrderState
    {
        bool CanShip(Order order);
        void Ship(Order order);

        bool CanCancel(Order order);
        void Cancel(Order order);

        OrderStatus Status { get; }
    }
}

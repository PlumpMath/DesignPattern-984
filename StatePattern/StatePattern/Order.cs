using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order
    {

        private IOrderState _orderState;
        public Order(IOrderState orderState)
        {
            this._orderState = orderState;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }

        public OrderStatus Status()
        {
            return _orderState.Status;
        }

        public bool CanCancel()
        {
            return _orderState.CanCancel(this);
        }

        public void Cancel()
        {
            if (this.CanCancel())
            {
                _orderState.Cancel(this);
            }
        }

        public bool CanShip()
        {
            return _orderState.CanCancel(this);
        }

        public void Ship()
        {
            if (this.CanShip())
            {
                _orderState.Ship(this);
            }
        }

        public void Change(IOrderState orderState)
        {
           this._orderState = orderState;
        }
    }
}

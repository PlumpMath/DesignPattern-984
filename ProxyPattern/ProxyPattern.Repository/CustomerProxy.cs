using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProxyPattern.Model;

namespace ProxyPattern.Repository
{
    public class CustomerProxy : Customer
    {
        private bool _haveLoadedOrders = false;

        private IEnumerable<Order> _orders;

        public IOrderRepository OrderRepository { get; set; }

        public bool HaveLoadedOrders()
        {
            return this._haveLoadedOrders;
        }

        public override IEnumerable<Order> Orders
        {
            get
            {
                if (!HaveLoadedOrders())
                {
                    RetrieeveOrders();
                    _haveLoadedOrders = true;
                }
                return _orders;
            }
            set
            {
                base.Orders = value;
            }
        }

        private void RetrieeveOrders()
        {
            this._orders = OrderRepository.FindAllBy(base.Id);
        }
    }
}

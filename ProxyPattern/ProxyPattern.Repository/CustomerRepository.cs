using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProxyPattern.Model;

namespace ProxyPattern.Repository
{

    public class CustomerRepository:ICustomerRepository
    {
        private IOrderRepository _orderRepository;

        public CustomerRepository(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public Customer FindBy(Guid id)
        {
            Customer customer = new CustomerProxy();

            //

            ((CustomerProxy)customer).OrderRepository = _orderRepository;


            return customer;
        }
    }
}

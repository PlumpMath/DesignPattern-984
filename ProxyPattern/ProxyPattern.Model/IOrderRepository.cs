using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.Model
{
    public interface IOrderRepository
    {
        IEnumerable<Order> FindAllBy(Guid customerId);
    }
}

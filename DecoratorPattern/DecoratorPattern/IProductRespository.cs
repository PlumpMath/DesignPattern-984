using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public interface IProductRespository
    {
        IEnumerable<Product> FindAll();
    }
}

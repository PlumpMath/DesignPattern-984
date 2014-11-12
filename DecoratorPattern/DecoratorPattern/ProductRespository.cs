using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class ProductRespository : IProductRespository
    {
        public IEnumerable<Product> FindAll()
        {
            IEnumerable<Product> products = new List<Product>(){
                new Product() { Price = new BasePrice(100m) },
                 new Product() { Price = new BasePrice(200m) },
                  new Product() { Price = new BasePrice(300m) }
            };
            return products;
        }
    }
}

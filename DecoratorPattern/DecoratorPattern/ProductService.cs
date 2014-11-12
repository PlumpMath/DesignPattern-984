using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class ProductService
    {
        private IProductRespository _productRespository;
        public ProductService(IProductRespository productRespository)
        {
            this._productRespository = productRespository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products = _productRespository.FindAll();
            products.ApplyTradeDiscount(); products.ApplyCurrencyMultiplier();
            return products;
        }
    }
}

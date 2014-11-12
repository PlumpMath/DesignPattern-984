using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductRespository productRespository = new ProductRespository();
            ProductService productService = new ProductService(productRespository);
            IEnumerable<Product> products = productService.GetAllProducts();
            foreach (var item in products)
            {
                Console.WriteLine(item.Price.Cost);
            }
            Console.ReadKey();
        }
    }
}

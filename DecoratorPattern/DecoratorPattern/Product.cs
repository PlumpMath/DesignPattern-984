using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 商品 
    /// </summary>
    public class Product
    {
        public IPrice Price { get; set; }
    }
}

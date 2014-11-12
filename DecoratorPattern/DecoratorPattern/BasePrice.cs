using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 提供商品的默认行为
    /// </summary>
    public class BasePrice : IPrice
    {
        public BasePrice(decimal cost)
        {
            this.Cost = cost;
        }
        public decimal Cost { get; set; }
    }
}

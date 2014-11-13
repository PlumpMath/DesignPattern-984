using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 无优惠，Null Object模式
    /// </summary>
    public class NoBasketDiscount:IBasketDiscountStrategy
    {

        public decimal GetTotalCostForDiscount(Basket basket)
        {
            return basket.TotalCost;
        }
    }
}

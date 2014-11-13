using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 打折
    /// </summary>
    public class BasketDiscountPercentageOff:IBasketDiscountStrategy
    {

        public decimal GetTotalCostForDiscount(Basket basket)
        {
            return basket.TotalCost * 0.85m;
        }
    }
}

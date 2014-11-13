using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 满减
    /// </summary>
    public class BasketDicountMoneyOff : IBasketDiscountStrategy
    {

        public decimal GetTotalCostForDiscount(Basket basket)
        {
            if (basket.TotalCost>100)
            {
                return basket.TotalCost - 10m;
            }
            if (basket.TotalCost > 50)
            {
                return basket.TotalCost - 5m;
            }
            else
            {
                return basket.TotalCost;
            }
        }
    }
}

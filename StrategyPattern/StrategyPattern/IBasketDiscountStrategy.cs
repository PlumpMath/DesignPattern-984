using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 购物车策略类
    /// </summary>
    public interface IBasketDiscountStrategy
    {
        decimal GetTotalCostForDiscount(Basket basket);
    }
}

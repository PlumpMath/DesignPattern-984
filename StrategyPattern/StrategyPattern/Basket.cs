using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 购物车
    /// </summary>
    public class Basket
    {
        private IBasketDiscountStrategy _basketDiscountStrategy = null;
        public Basket(IBasketDiscountStrategy basketDiscountStrategy)
        {
            this._basketDiscountStrategy = basketDiscountStrategy;
        }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalCost { get; set; }

        public decimal GetTotalCostAfterDiscount()
        {
            return this._basketDiscountStrategy.GetTotalCostForDiscount(this);
        }
    }
}

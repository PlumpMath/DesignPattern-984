using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public static class BasketDiscountFactory
    {
        public static IBasketDiscountStrategy Create(DiscountType discountType)
        {
            switch (discountType)
            {
                case DiscountType.NoDiscount:
                    return new NoBasketDiscount();
                case DiscountType.MoneyOff:
                    return new BasketDicountMoneyOff();
                case DiscountType.PercentageOff:
                    return new BasketDiscountPercentageOff();
                default:
                    return new NoBasketDiscount();
            }
        }
    }
}

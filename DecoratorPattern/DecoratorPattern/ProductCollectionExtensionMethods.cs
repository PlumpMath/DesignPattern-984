using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 添加扩展方法，将装饰行为应用Product类
    /// </summary>
    public static class ProductCollectionExtensionMethods
    {
        public static void ApplyCurrencyMultiplier(this IEnumerable<Product> produces)
        {
            foreach (Product item in produces)
            {
                item.Price = new CurrencyPriceDecorator(item.Price, 0.78m);
            }
        }

        public static void ApplyTradeDiscount(this IEnumerable<Product> products)
        {
            foreach (Product item in products)
            {
                item.Price = new TradeDiscountPriceDecorator(item.Price);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /* 背景
     * 将折扣应用到电子商务购物车中
     * 
     * 模式意图
     * 定义一系列的算法，把它们一个个封装起来，并且使用它们可以
     * 相互替换。Strategy模式使得算法可独立于使用它的客户而变化
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            IBasketDiscountStrategy basketDiscountStrategy = BasketDiscountFactory.Create(DiscountType.MoneyOff);
            Basket basket = new Basket(basketDiscountStrategy) { TotalCost = 100 };
            decimal total = basket.GetTotalCostAfterDiscount();
            Console.WriteLine("原价100，打折后{0}",total);

            Console.Read();
        }
    }
}

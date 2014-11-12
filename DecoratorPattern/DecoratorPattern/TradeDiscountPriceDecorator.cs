using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 提供95折商业折扣
    /// </summary>
    public class TradeDiscountPriceDecorator:IPrice
    {
        private IPrice _price;
        public TradeDiscountPriceDecorator(IPrice price)
        {
            _price = price;
        }


        public decimal Cost
        {
            get
            {
                return _price.Cost * 0.95m;
            }
            set
            {
                _price.Cost = value;
            }
        }
    }
}

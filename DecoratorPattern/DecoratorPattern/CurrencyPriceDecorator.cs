using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 提供指定折扣
    /// </summary>
    public class CurrencyPriceDecorator:IPrice
    {
        private IPrice _price;
        private decimal _exchangeRate;

        public CurrencyPriceDecorator(IPrice price,decimal exchangeRate)
        {
            this._price = price;
            this._exchangeRate = exchangeRate;
        }

        public decimal Cost
        {
            get
            {
                return _price.Cost * _exchangeRate;
            }
            set
            {
                _price.Cost = value;
            }
        }
    }
}

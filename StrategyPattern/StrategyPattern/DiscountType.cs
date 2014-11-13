using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 折扣模式
    /// </summary>
    public enum DiscountType
    {
        NoDiscount=0,
        MoneyOff=1,
        PercentageOff=2
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 价格
    /// </summary>
    public interface IPrice
    {
        decimal Cost { get; set; }
    }
}

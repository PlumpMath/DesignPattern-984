using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 退货处理模式
    /// </summary>
    public enum ReturnAction
    {
        /// <summary>
        /// 缺陷商品退货
        /// </summary>
        FaultyReturn = 0,
        /// <summary>
        /// 无损商品退货
        /// </summary>
        NoQuibblesReturn = 1
    }
}

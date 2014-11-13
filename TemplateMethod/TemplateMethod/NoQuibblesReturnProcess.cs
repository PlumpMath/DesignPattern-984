using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 无损退货处理
    /// </summary>
    public class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        /// <summary>
        /// 计算退货金额
        /// </summary>
        /// <param name="returnOrder"></param>
        protected override void CalclateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid + returnOrder.PostageCost;
        }

        /// <summary>
        /// 无损商品退货时增加库存量
        /// </summary>
        /// <param name="returnOrder"></param>
        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            Console.WriteLine("库存增加了");
        }
    }
}

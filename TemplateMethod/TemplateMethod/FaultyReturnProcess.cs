using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 缺陷商品退货处理
    /// </summary>
    public class FaultyReturnProcess : ReturnProcessTemplate
    {

        /// <summary>
        /// 计算退货费用
        /// </summary>
        /// <param name="returnOrder"></param>
        protected override void CalclateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid + returnOrder.PostageCost; 
        }

        /// <summary>
        /// 缺陷商品需要返厂修理
        /// </summary>
        /// <param name="returnOrder"></param>
        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            Console.WriteLine("创建了一张返厂单");
        }
    }
}

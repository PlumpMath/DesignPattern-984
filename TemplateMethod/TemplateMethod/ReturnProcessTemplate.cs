using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 退货处理模版
    /// </summary>
    public abstract class ReturnProcessTemplate
    {
        /// <summary>
        /// 计算退还费用
        /// </summary>
        /// <param name="returnOrder"></param>
        protected abstract void CalclateRefundFor(ReturnOrder returnOrder);

        /// <summary>
        /// 退货处理事务
        /// </summary>
        /// <param name="returnOrder"></param>
        protected abstract void GenerateReturnTransactionFor(ReturnOrder returnOrder);


        /// <summary>
        /// 退货处理
        /// </summary>
        /// <param name="returnOrder"></param>
        public void Process(ReturnOrder returnOrder)
        {
            GenerateReturnTransactionFor(returnOrder);
            CalclateRefundFor(returnOrder);
        }
    }
}

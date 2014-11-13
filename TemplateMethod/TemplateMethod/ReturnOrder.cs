using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 退货订单
    /// </summary>
    public class ReturnOrder
    {
        /// <summary>
        /// 退货类型
        /// </summary>
        public ReturnAction Action { get; set; }
        /// <summary>
        /// 原始订单ID
        /// </summary>
        public string PayMentTransactionId { get; set; }
        /// <summary>
        /// 订单总价
        /// </summary>
        public decimal PricePaid { get; set; }
        /// <summary>
        /// 运费
        /// </summary>
        public decimal PostageCost { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// 退货金额
        /// </summary>
        public decimal AmountToRefund { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 货物订单
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 总花费 
        /// </summary>
        public int TotalCost { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public int WeightInKG { get; set; }

        /// <summary>
        /// 快递ID
        /// </summary>
        public string CourierTrackId { get; set; }

        /// <summary>
        /// 派件地址
        /// </summary>
        public Address DispatchAddress { get; set; }
    }
}

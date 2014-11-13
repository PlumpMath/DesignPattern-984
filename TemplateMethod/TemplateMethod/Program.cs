using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 退货系统
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ReturnOrder returnOrder = new ReturnOrder()
            {
                Action = ReturnAction.FaultyReturn,
                PayMentTransactionId = "20141113",
                PostageCost = 10,
                PricePaid = 110,
                ProductId = 1
            };
            ReturnService returnService = new ReturnService();
            returnService.Process(returnOrder);
            Console.WriteLine("退款金额为：{0}",returnOrder.AmountToRefund);
            Console.Read();
        }
    }
}

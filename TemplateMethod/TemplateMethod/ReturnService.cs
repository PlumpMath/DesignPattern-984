using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 退货处理
    /// </summary>
    public class ReturnService
    {
        public void Process(ReturnOrder returnOrder)
        {
            ReturnProcessTemplate returnProcessTemplate = ReturnProcessFactory.Create(returnOrder.Action);
            returnProcessTemplate.Process(returnOrder);
        }
    }
}

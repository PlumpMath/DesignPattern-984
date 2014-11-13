using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 工厂
    /// </summary>
    public static class ReturnProcessFactory
    {
        public static ReturnProcessTemplate Create(ReturnAction returnAction)
        {
            switch (returnAction)
            {
                case ReturnAction.FaultyReturn:
                    return new FaultyReturnProcess();
                case ReturnAction.NoQuibblesReturn:
                    return new NoQuibblesReturnProcess();
                default:
                    return null;
            }
        }
    }
}

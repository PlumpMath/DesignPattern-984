using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /// <summary>
    /// 欠费规则类
    /// </summary>
    public class CustomerAccountHasLateFeesSpecification:CompositeSpecification<CustomerAccount>
    {
        public override bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.LateFees > 0;
        }
    }
}

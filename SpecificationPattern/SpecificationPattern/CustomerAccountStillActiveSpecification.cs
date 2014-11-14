using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /// <summary>
    /// 账户限制规格类
    /// </summary>
    public class CustomerAccountStillActiveSpecification : CompositeSpecification<CustomerAccount>
    {
        public override bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.AccountActive;
        }
    }
}

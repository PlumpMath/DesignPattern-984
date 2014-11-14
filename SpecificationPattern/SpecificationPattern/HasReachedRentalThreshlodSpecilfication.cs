using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /// <summary>
    /// 租借上限规则
    /// </summary>
    public class HasReachedRentalThreshlodSpecilfication : CompositeSpecification<CustomerAccount>
    {
        public override bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.NumberOfRentalsThisMonth > 5;
        }
    }
}

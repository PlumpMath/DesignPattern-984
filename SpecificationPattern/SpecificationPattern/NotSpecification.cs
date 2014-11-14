using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /// <summary>
    /// Not 操作类
    /// </summary>
    public class NotSpecification<T>:CompositeSpecification<T>
    {
        private ISpecification<T> _specification;

        public NotSpecification(ISpecification<T> specification)
        {
            this._specification = specification;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return !_specification.IsSatisfiedBy(candidate);
        }

    }
}

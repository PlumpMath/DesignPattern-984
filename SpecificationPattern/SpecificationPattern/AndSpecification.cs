using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /// <summary>
    /// And 操作类
    /// </summary>
    public class AndSpecification<T>:CompositeSpecification<T>
    {
        private ISpecification<T> _leftSpecification;
        private ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> leftSpecification,ISpecification<T> rightrightSpecification)
        {
            this._leftSpecification = leftSpecification;
            this._rightSpecification = rightrightSpecification;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return _leftSpecification.IsSatisfiedBy(candidate) && _rightSpecification.IsSatisfiedBy(candidate);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /// <summary>
    /// Or 操作类
    /// </summary>
    public class OrSpecification<T>:CompositeSpecification<T>
    {
        private ISpecification<T> _leftSpecification;
        private ISpecification<T> _rightSpecification;

        public OrSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightrightSpecification)
        {
            this._leftSpecification = leftSpecification;
            this._rightSpecification = rightrightSpecification;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return _leftSpecification.IsSatisfiedBy(candidate) || _rightSpecification.IsSatisfiedBy(candidate);
        }

    }
}

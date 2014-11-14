using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachRentalThreshold = null;

        public CustomerAccount()
        {
            this._hasReachRentalThreshold = new HasReachedRentalThreshlodSpecilfication();
        }

        /// <summary>
        /// 租借数量上限
        /// </summary>
        public decimal NumberOfRentalsThisMonth { get; set; }

        /// <summary>
        /// 是否受限制
        /// </summary>
        public bool AccountActive { get; set; }

        /// <summary>
        /// 所欠费用
        /// </summary>
        public decimal LateFees { get; set; }

        public bool CanRent()
        {
            return !_hasReachRentalThreshold.IsSatisfiedBy(this);
        }
    }
}

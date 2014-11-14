using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /* 背景
     * 一个租赁系统，查询顾客是否超过租借数目上限、是否做了限制、是否欠费
     * 
     * 模式意图
     * Specification（规格）模式用于把布尔算法中的业务逻辑封装到业务实体之外。
     * 然后可以把这些可管理的逻辑单元链接起来，形成更灵活的复杂业务逻辑。
     * 我们是无法共享或重用嵌入业务实体中的选择查询条件。Specification模式
     * 试图通过把用来匹配对象的业务逻辑从实际的对象中分离出来去解决这个问题。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAccount customerAccount=new CustomerAccount(){ 
                NumberOfRentalsThisMonth=4, LateFees=10, AccountActive=true};
            CustomerAccountHasLateFeesSpecification customerAccountHasLateFeesSpecification = new CustomerAccountHasLateFeesSpecification();
            customerAccountHasLateFeesSpecification.IsSatisfiedBy(customerAccount);



            CustomerAccount customerActive = new CustomerAccount() { AccountActive = true, LateFees = 100 };
            ISpecification<CustomerAccount> specificationActive = new CustomerAccountStillActiveSpecification();
            ISpecification<CustomerAccount> specificationLateFees = new CustomerAccountHasLateFeesSpecification();
            specificationActive.And(specificationLateFees).IsSatisfiedBy(customerActive);
        }
    }
}

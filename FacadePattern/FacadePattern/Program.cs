using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    /*
     * 模式意图
     * Facade模式简化了一个复杂的子系统或一组子系统的接口，
     * 为客户提供一个简单的API，使其与客户使用的其它API报纸
     * 一致。
     * Facade模式可以在很多场合使用：
     * 可以采用一种与应用程序其余部分一致的接口打包第三方库。
     * 通过把对其它系统的和库的依赖关系抽象处理啊，使代码松耦合
     * 可以用一个更简单的接口来打包复杂的子系统。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.Test();

            Console.ReadKey();
        }
    }
}

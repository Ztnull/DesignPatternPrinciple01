using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.SRP
{
    /// <summary>
    /// 单一职责【封装】：
    ///     一个类值做好自己的一件事情
    ///     如果一个类的职责（实现）的太多，A的变化会影响到B，会造成整个程序的不稳定
    ///     好处：逻辑分离，易于理解和实现
    ///     坏处：只能加成本
    /// </summary>
    public class SRPShow
    {
       
        public static void Show()
        {
            {
                Animal animal = new Animal("鸡");
                animal.Breath();
            }
            {
                Animal animal = new Animal("狗");
                animal.Breath();
            }
        }
    }
}

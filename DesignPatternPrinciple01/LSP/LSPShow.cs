using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.LSP
{
    /// <summary>
    /// 继承
    /// 里氏替换原则：任何使用基类的地方，都可以透明的使用其子类
    /// 
    /// 继承、多态
    /// 
    /// 
    /// *****************
    /// 普通方法的调用、由编译时决定
    /// 抽象/虚方法、由运行时决定
    /// </summary>
    public class LSPShow
    {


        public static void Show()
        {
            Console.WriteLine("********************Show*******************");
            Poly.Test();

            {

            }
        }


    }
}

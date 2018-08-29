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
    /// 1、如果子类不完全拥有父类的所有属性和行为，就断掉继承
    /// 2、子类可以拥有自己的属性和行为，子类出现的地方父类不一定能替换【子类出现的地方，父类不一定能替换；父类出现的地方，子类一定能替换】
    /// 3、父类实现的方法，子类不要改写、隐藏
    ///     若要重新实现，请使用：virtual、abstract
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
                Chinese chinesePeople = new Chinese();
                chinesePeople.Traditional();
                DoChines(chinesePeople);
            }

            {//里氏替换原则：任何基类实现的地方，都可以透明的使用其子类
                Chinese chineseSC = new SiChuan();
                chineseSC.Traditional();// 这里调用父类的方法
                DoChines(chineseSC);//这里调用父类的方法

            }
            {
                SiChuan siChuan = new SiChuan();
                siChuan.Traditional();//调用父类
                DoChines(siChuan);//调用父类
            }
        }

        private static void DoChines(Chinese chinese)
        {
            Console.WriteLine($"{chinese.ID}    {chinese.Kuaizi}    {chinese.Name}");
            chinese.SayHi();
        }

    }
}

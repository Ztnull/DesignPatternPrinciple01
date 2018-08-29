using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.DIP
{
    /// <summary>
    /// 抽象：接口/抽象类
    /// 细节：类（每个类）
    /// 依赖倒置原则：上层模块不应该依赖于底层模块，二者应该通过抽象依赖
    /// 
    /// 【依赖倒置的核心思想  -----> 依赖于抽象】
    /// 相对于细节的多变，抽象是稳定的
    /// 基于抽象的架构会更稳定
    /// 
    /// 倒置：上层不再依赖下层的实现，而是依赖抽象
    /// 
    /// 依赖倒置（DIP）：设计模式原则
    /// 控制反转（IOC）：将上层对下层的直接控制，交给了第三方的容器；也就是new的动作交给了第三方（配置文件）去管理
    /// 依赖注入（DI）：实现IOC的手段，所以经常将DI和IOC一起使用【依赖注入、控制反转】。
    /// {上层调用需要实现的时候，而底层并没有实现，我们和将通过一些手段【注入：构造函数】从上层注入到下层去实现}
    /// 目的（IOC）----->实现的手段---->依赖注入（DI）
    /// </summary>
    public class DIPShow
    {
        public static void Show()
        {

            Console.WriteLine("**************DIPShow***************");
            Student student = new Student()
            {
                ID = 19,
                Name = "班长"
            };
            {
                iPhone phone = new iPhone();
                student.PlayiPhone(phone);
            }
            {
                Mi phone = new Mi();
                student.PlayMi(phone);
            }
        }
    }
}

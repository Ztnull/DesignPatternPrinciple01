using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.ISP
{
    /// <summary>
    /// 接口隔离原则：客户端不应该依赖于他需要的接口；
    ///             一个类对另一个类的依赖应该建立在最小的接口上
    ///
    /// 不能大而全的接口，这样会导致实现不必要的接口
    /// 也不能过度拆分，导致太过于分散，使用不便
    /// 接口也有封装性：比如（BaseDAL （一个增删改查的接口基类：所有的类实现））
    /// 
    /// 
    /// 最重要的事合理选择，量情度事
    /// 单一职责关注的是类；接口隔离关注的是接口的功能（整体化）
    /// </summary>
    public class ISPShow
    {

    }
}

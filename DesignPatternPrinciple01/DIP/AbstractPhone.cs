using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.DIP
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class AbstractPhone
    {
        public int ID { get; set; }
        public string Branch { get; set; }

        public abstract void Call();
        public abstract void Text();
    }
}

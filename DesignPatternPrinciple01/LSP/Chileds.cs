using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.LSP
{

    public class Chinese : People
    {
        public string Kuaizi { get; set; }
        public void SayHi()
        {
            Console.WriteLine("早上好，吃了吗？");
        }
    }

    public class SiChuan : Chinese
    {
        public int LaJiao { get; set; }
        public new void SayHi()//隐藏父类
        {
            Console.WriteLine("早上好，过早了么？");
        }
    }

    /// <summary>
    /// 没有代码重用
    /// 
    /// </summary>
    public class Japanese1 //: People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public new void Traditional()
        //{
        //    Console.WriteLine("忍者精神 ");
        //}
        public void Ninja()
        {
            Console.WriteLine("忍者精神 ");
        }

    }


    /// <summary>
    /// 错误做法
    /// 通过继承，代码重用
    /// 但是呢，Traditional子类没有，所以单独处理
    /// 
    /// 导致客户端在使用的时候，还得区分不同的类型，得修改代码
    /// </summary>
    public class Japanese2 : People
    {
        public new void Traditional()
        {
            throw new Exception("NO Traditional");
        }
        public void Ninja()
        {
            Console.WriteLine("忍者精神 ");
        }

    }

}

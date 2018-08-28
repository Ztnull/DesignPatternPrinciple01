using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.SRP
{
    public class Chiecken : AbstractAnimal
    {
        public Chiecken(string name ) : base(name)//调用父类构造函数
        {

        }
        public override void Breath()
        {
            Console.WriteLine($"{base._Name} 呼吸空气");
        }
    }
}

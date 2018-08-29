using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.DIP
{
    public class Lumia : AbstractPhone
    {
        public override void Call()
        {
            Console.WriteLine($"Use {this.GetType().Name} Call");
        }

        public override void Text()
        {
            Console.WriteLine($"Use {this.GetType().Name} Text");
        }
    }
}

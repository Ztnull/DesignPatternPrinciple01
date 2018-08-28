using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.SRP
{
    public class Fish : AbstractAnimal
    {
        public Fish(string name) : base(name)
        {

        }
        public override void Breath()
        {
            Console.WriteLine($"{base._Name} 呼吸水");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.SRP
{
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

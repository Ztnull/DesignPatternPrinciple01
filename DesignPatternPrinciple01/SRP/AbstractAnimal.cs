 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.SRP
{
    public abstract class AbstractAnimal
    {
        protected string _Name = string.Empty;

        public AbstractAnimal(string name)
        {
            this._Name = name;
        }
 

        public abstract void Breath();
    }
}

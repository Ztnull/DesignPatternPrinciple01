using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.ISP
{
    public class Sony : IPhotoVideo
    {
        public void Photo()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Video()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }
    }
}

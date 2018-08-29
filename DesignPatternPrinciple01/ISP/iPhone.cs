using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.ISP
{
    public class iPhone : AbstractPhone, IExtend, IExtendAdvanced, IPhotoVideo
    {
        public override void Call()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Game()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Map()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Movie()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Music()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Online()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Pay()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Photo()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Record()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public override void Text()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }

        public void Video()
        {
             Console.WriteLine("User {0} Call", this.GetType().Name);
        }
    }
}

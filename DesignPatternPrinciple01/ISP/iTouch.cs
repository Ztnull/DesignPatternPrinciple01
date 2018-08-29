using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.ISP
{
    public class iTouch : IExtend
    {
        public void Game()
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

        //public void Photo()
        //{
        //     Console.WriteLine("User {0} Call", this.GetType().Name);
        //}

        //public void Video()
        //{
        //     Console.WriteLine("User {0} Call", this.GetType().Name);
        //}
    }
}

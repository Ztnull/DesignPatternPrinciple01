using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.DIP
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public void PlayiPhone(iPhone iPhone)
        {
            Console.WriteLine($"这里是{this.Name}");
        }

        public void PlayMi(Mi MiPhone)
        {
            Console.WriteLine($"这里是{this.Name}");
        }

        /// <summary>
        /// 抽象
        /// </summary>
        /// <param name="Phone"></param>
        public void PlayPhone(AbstractPhone Phone)
        {
            Console.WriteLine($"这里是{this.Name}");
        }
    }
}

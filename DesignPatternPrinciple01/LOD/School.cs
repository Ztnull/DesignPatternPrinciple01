using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.LOD
{
    /// <summary>
    /// 学校
    /// </summary>
    public class School
    {
        public int ID { get; set; }
        public string SchName { get; set; }

        public List<Class> ClassList { get; set; }//属性 组合

        public void Manage()
        {
            Console.WriteLine($"Manage {this.GetType().Name}");
            foreach (Class c in this.ClassList)
            {
                Console.WriteLine(" {0}Manage {1} ", c.GetType().Name, c.ClassName);
            }
        }
    }
}

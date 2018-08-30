using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01
{
    class Program
    {
        /// <summary>
        /// 1.  单一职责原则（Single Responsibility Principle）
        /// 2.  里氏替换原则（Liskov Substitution Principle）
        /// 3.  依赖倒置原则（Dependence Inversion Principle）
        /// 4.  接口隔离原则（Interface Segregation Principle）
        /// 5.  迪米特法则  （Law Of Demeter）
        /// 6： 开闭原则(Open Closed Principle)
        /// 
        /// 
        /// 设计模式的六大原则：只是一个指导性的原则，如何遵循需要自己度量
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("*******************设计模式 六大原则*******************");
            Console.WriteLine("1.  单一职责原则（Single Responsibility Principle）");
            Console.WriteLine("2.  里氏替换原则（Liskov Substitution Principle）");
            Console.WriteLine("3.  依赖倒置原则（Dependence Inversion Principle）");
            Console.WriteLine("4.  接口隔离原则（Interface Segregation Principle）");
            Console.WriteLine("5.  迪米特法则  （Law Of Demeter）");
            Console.WriteLine("6： 开闭原则(Open Closed Principle)");




            try
            {
                Console.WriteLine("*******************里氏替换原则*******************");
                LSP.LSPShow.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            Console.ReadKey();
        }
    }
}

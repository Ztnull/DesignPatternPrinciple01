using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.LSP
{
    public class Poly
    {
        public static void Test()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            {

                ParentClass instance = new ChildClass();
                Console.WriteLine("下面是instance.CommMethod");
                instance.CommMethod();
                Console.WriteLine("下面是instance.VirtualMethod");
                instance.VirtualMethod();
                Console.WriteLine("下面是instance.AbstractMethod");
                instance.AbstractMethod();

            }
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
    }


    public abstract class ParentClass
    {
        /// <summary>
        /// CommMethod
        /// </summary>
        public void CommMethod()
        {
            Console.WriteLine("ParentClass CommMethod");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("ParentClass VirtualMethod");
        }

        /// <summary>
        ///abstract
        /// </summary>
        public abstract void AbstractMethod();
    }


    public class ChildClass : ParentClass
    {
        public new void CommMethod()
        {
            Console.WriteLine("ChildClass CommMethod");
        }

        public void CommonMethod(int id, string name = "", string des = "", int size = 0)
        {
            Console.WriteLine("ChildClass CommonMethod");
        }

        public void CommonMethod(string name, int id)
        {
            Console.WriteLine("ChildClass CommonMethod");
        }

        public override void VirtualMethod()
        {
            Console.WriteLine("ChildClass AbstractMethod");
            base.VirtualMethod();
        }

        public sealed override void AbstractMethod()
        {
            Console.WriteLine("ChildClass VirtualMethod");
        }

    }

    public class GrandClass : ChildClass
    {

        //public override void AbstractMethod()
        //{
        //    base.AbstractMethod();
        //}

        public override void VirtualMethod()
        {
            base.VirtualMethod();
        }
    }
}

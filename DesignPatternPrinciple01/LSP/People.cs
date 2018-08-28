using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.LSP
{
    /// <summary>
    /// 基类
    /// </summary>
    public class People
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public void Traditional()
        {
            Console.WriteLine("Traditional");
        } 
    }

}

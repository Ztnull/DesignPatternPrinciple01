using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.SRP
{
    /// <summary>
    /// 封装
    /// 动物类
    /// 意味着稳定
    /// </summary>
    public class Animal
    {
        private string _Name = string.Empty;

        public Animal(string name)
        {
            this._Name = name;
        }

        public void Breath()
        {
            Console.WriteLine($"{_Name}：呼吸空气");
        }
    }
}

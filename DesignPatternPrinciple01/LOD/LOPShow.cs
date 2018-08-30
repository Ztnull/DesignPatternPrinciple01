using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.LOD
{
    /// <summary>
    /// 迪米特法则（最少知道原则）：一个对象应该对其他对象保持最少的了解
    /// 只与直接的朋友通信
    /// 
    /// 高内聚低耦合
    /// 
    /// 直接的朋友：学校而言，班级是直接的朋友，学生不是的
    /// 
    /// 纵向关系：继承  实现
    /// 横向关系：依赖（方法内部）  关联  组合  聚合(方法返回值/参数   属性)
    /// 
    ///  
    /// 
    /// </summary>
    public class LOPShow
    {
        public static void Show()
        {
            Console.WriteLine("****************************");
            School school = new School()
            {
                SchName = "xxx学校",
                ClassList = new List<Class>()
                {
                    new Class ()
                    {
                         ClassName="12班",
                         StudentList= new List<Student>()
                         {
                              new Student()
                              {
                                   ID=1,
                                    StuName="王八"
                              },
                         },
                    }
                },
            };
            school.Manage();
        }
    }
}

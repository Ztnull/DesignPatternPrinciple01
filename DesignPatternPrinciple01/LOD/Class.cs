using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.LOD
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        //老师

        public List<Student> StudentList { get; set; }


        public void Manage()
        {
            foreach (Student s in this.StudentList)
            {
                Console.WriteLine(" {0}Manage {1} ", s.GetType().Name, s.StuName);
            }
        }
    }
}

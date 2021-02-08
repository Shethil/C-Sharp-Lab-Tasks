using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Shethil","19-39698");
            s1.showInfo();
            s1.Department = "CSE";
            s1.Cgpa = 3.75f;

            Triangle t1 = new Triangle(5, 6, 7);
            t1.showInfo();
            t1.TestTriangle();

        }
    }

}

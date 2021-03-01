using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Shethil", "123", 3.7f);
            Student s2 = new Student("Rahim", "124", 3.5f);
            Student s3 = new Student("Karim", "125", 3.2f);

            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Enginnering", "EEE");
        

            d1.AddStudent(s1);
            d1.AddStudent(s2);
            d2.AddStudent(s3);

            s1.ShowDepartmentDetails();
            s3.ShowDepartmentDetails();



     
        }
    }
}

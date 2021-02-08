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
            Student s1 = new Student("Shethil","19-39698-1");
            s1.Department = "CSE";
            s1.Cgpa = 3.75f;
            s1.showInfo();

            Console.WriteLine();

            Triangle t1 = new Triangle(5, 6, 7);
            t1.showInfo();
            t1.TestTriangle();

            Console.WriteLine();

            Account a1 = new Account("Shithil", "12345", 5000);
            a1.showInfo();
            a1.Deposit(2000);
            a1.Withdraw(1000);
            a1.showInfo();

            Console.WriteLine();

            Course c1 = new Course("OOP2","112",3);
            c1.ShowCourseInfo();

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        String name;
        String id;
        String department ;
        float cgpa;

       public Student()
        {
            Console.WriteLine("This is a constructor with one parameter");
        }

       public  Student(String name , String id)
        {
            Console.WriteLine("This is a constructor with two parameter");
            this.name = name;
            this.id = id;
        }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public String Id
        {
            set { id = value; }
            get { return id; }
        }

        public String Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        public void showInfo()
        {
            Console.WriteLine("Name is :"+name);
            Console.WriteLine("ID is :"+id);
            Console.WriteLine("Department is :"+department);
            Console.WriteLine("CGPA is :"+cgpa);
        }
    }
}

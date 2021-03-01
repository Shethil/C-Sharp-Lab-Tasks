using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        private Student[] student;

        public void AddStudent(Student s)
        {
             student[studentCount] = s ;
             studentCount++;
        }

        public void PrintStudent()
        {
            for (int i=0; i < studentCount; i++)
            {
                student[i].showInfo();
            }
        }

        public Student GetStudent(string id)
        {
            return null;
        }

        private int studentCount;
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }


        public Department()
        {
            student = new Student[60];
        }
        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void showInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID   : " + id);
            student = new Student[60];
            studentCount = 0;
        }
    }
}

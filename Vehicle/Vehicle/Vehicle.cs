using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        int registrationNumber;
        String registrationDate;
        int cc;

        public int RegistrationNumber
        {
            set { registrationNumber = value; }
            get { return registrationNumber; }
        }

        public String RegistrationDate
        {
            set { registrationDate = value; }
            get { return registrationDate; }
        }

        public int Cc
        {
            set { cc = value; }
            get { return cc; }
        }


        public Vehicle()
        {
            Console.WriteLine("This is default constructor");
        } 
        public Vehicle(int registrationNumber, String registrationDate, int cc)
        {
            Console.WriteLine("This is parameterized constructor");
            Console.WriteLine("Registration Number " + registrationNumber);
            Console.WriteLine("Registration Date " + registrationDate);
            Console.WriteLine("CC    " + cc);
        }

        public void showInfo()
        {
            Console.WriteLine("Registration Number " + registrationNumber);
            Console.WriteLine("Registration Date " + registrationDate);
            Console.WriteLine("CC    " + cc);
        }
        


    }
}

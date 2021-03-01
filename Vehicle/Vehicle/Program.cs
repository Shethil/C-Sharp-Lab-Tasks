using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
          Vehicle car1 = new Vehicle();
          car1.RegistrationNumber = 123;
          car1.RegistrationDate = "12 - 12 - 18";
          car1.Cc = 1200;

          car1.showInfo();

          Console.WriteLine();

          Vehicle car2 = new Vehicle(124, "12-12-18", 1400);

          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public void showInfo()
        {
            Console.WriteLine("Length of 1st edge is {0} :",x);
            Console.WriteLine("Length of 2nd edge is {1} :", y);
            Console.WriteLine("Length of 3rd edge is {2} :", z);
        }
    }
}

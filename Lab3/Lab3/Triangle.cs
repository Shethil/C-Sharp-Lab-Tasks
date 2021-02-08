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

        public Triangle(int x , int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void showInfo()
        {
            Console.WriteLine("Length of 1st edge is {0} ", x);
            Console.WriteLine("Length of 2nd edge is {0} ", y);
            Console.WriteLine("Length of 3rd edge is {0} ", z);
        }

        public void TestTriangle()
        {
            if (x == y && y == z)
                Console.WriteLine("triangle is equilateral");
            else if  ((x == y) || (y == z) || (z == x))
                Console.WriteLine("triangle is isosceles");
            else
                Console.WriteLine("triangle is scalene");

        }
    }
}

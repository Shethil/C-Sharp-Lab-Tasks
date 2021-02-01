using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");

            int x = 50, y = 5;

            int sum= x+y;
            Console.WriteLine("Sum is "+sum);

            int sub = x - y;
            Console.WriteLine("Subtraction is "+sub);

            int mul = x * y;
            Console.WriteLine("Multiplication is " + mul);

            int div = x / y;
            Console.WriteLine("Divition is " + div);

            
            string  a=Console.ReadLine();
            int z = Int32.Parse(a);
            Console.WriteLine(z);

        }
    }
}

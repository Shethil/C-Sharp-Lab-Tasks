using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd_sum=0;
            int even_sum=0;

            for (int i = 0; i <= 100; i++) 
            {
                if (i % 2 == 0)
                    even_sum = even_sum + i;

                else
                    odd_sum = odd_sum + i;
            }

            Console.WriteLine("Even sum is {0}", even_sum);
            Console.WriteLine("Odd sum is {0}", odd_sum);

        }
    }
}

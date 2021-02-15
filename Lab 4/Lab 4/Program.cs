using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
  
            // Problem 1 

            int[] arr1 = new int[100];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 100 + 1;
            }
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("arr1[i] :"+i);
            } 

            // Problem 2

            int sum = 0;

            int[] arr2 = new int[] {1,2,3,4,5,6} ;

            for (int i = 0; i < arr2.Length; i++)
            {
                sum = sum + arr2[i];
            }

            Console.WriteLine("\nThe sum is" + sum+"\n");

            // problem 3  

            int[] arr3 = new int[5] {10,20,30,40,50};
            int[] arr4 = new int[5];

            for (int i = 0; i < arr3.Length; i++)
            {
                arr4[i] = arr3[i];
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }


            // problem 4

            int[] arr5 = new int[10] {1,1,4,5,6,6,7,9,9,9};
            int[] arr6 = new int[10];

            for (int i = 0; i < arr5.Length; i++)
            {
                arr6[i] = arr5[i];
            }
        /*    for (int i = 0; i < arr5.Length; i++)
            {
                Console.WriteLine(arr6[i]);
            } */
            int count=0;

            for (int i = 0; i < arr5.Length; i++)
            {
                for (int j = i + 1; j < arr5.Length; j++)
                {
                    if (arr5[i] == arr6[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\nTotal number of duplicate elements found in array = " + count+"\n\n\n");

        }
    }
}

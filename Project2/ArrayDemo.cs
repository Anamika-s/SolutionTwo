using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class ArrayDemo
    {
        static void Main()
        {
            int[] num = new int[10];
            Console.WriteLine("enter numbers");
            for (int i = 0; i < 10; i++)
            {
                
                num[i] = Convert.ToByte(Console.ReadLine());
            }
            //Console.WriteLine("elements are");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            // we can use for loop and foreach loop to iterate 
            // thru array or collection

            // foreach(datatype range_variable in array/collection)
            //   cw(range_variable)

            foreach (int temp in num)
            
                Console.WriteLine(temp);
        }
    }
}
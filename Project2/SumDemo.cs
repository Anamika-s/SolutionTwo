using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class SumDemo
    {
        static void Main()
        {
            //// sum of 10 numnbers
            //int sum = 0;
            //int num;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("enter num");
            //    // Byte , Range > 0 to 255
            //    num = Convert.ToSByte(Console.ReadLine());
            //    sum += num;
            //}
            //Console.WriteLine($"Sum is {sum}");

            // sum of +ve numbers and if user enters 0, stop doing summation
            // continue / break statement
            int sum = 0;
            int num;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter num");
                // Byte , Range > 0 to 255
                num = Convert.ToSByte(Console.ReadLine());
                if (num < 0) continue;
                if (num == 0) break;
                sum += num;
            }
            Console.WriteLine($"Sum is {sum}");

        }
    }
}
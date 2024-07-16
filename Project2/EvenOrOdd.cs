using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class EvenOrOdd
    {
        static void Main()
        {
            int x;
            Console.WriteLine("enter value of x");
            x = Convert.ToByte(Console.ReadLine());
            //if (x % 2 == 0)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("odd");
            // use ?: operator
            Console.WriteLine(x%2==0?"even":"odd");
        }
    }
}

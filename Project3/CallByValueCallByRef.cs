using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CallByValueCallByRef
    {
        static void Main()
        {
            int x = 100;
            Console.WriteLine($"value of x in Main before calling Change1 is {x}");
            Change1(x);
            Console.WriteLine($"value of x in Main after calling Change1 is {x}");
            Change2(ref x);
            Console.WriteLine($"value of x in Main after calling Change2 is {x}");


        }
        static void Change1(int x)
        {
            x = 1000;
            Console.WriteLine($"value of x in Change1 is {x}");
        }

        static void Change2(ref int x)
        {
            x = 2000;
            Console.WriteLine($"value of x in Change2 is {x}");
        }
    }
}

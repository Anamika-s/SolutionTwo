using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class SwitchDemo
    {
        static void Main()
        {
            int x, y;
            Console.WriteLine("enter value of x");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter value of y");
            y = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter choice");
            int ch = Convert.ToByte(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine($"Sum of {x} and {y} is {x + y}");
                    break;
                case 2:
                    Console.WriteLine($"Difference of {x} and {y} is {x - y}");
                    break;
                case 3:
                    Console.WriteLine($"Product of {x} and {y} is {x * y}");
                    break;
                case 4:
                    Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }

            }
        }
}

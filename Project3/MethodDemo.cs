using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class MethodDemo
    {
        static int x, y;
        static void Main()
        {

            Console.WriteLine("enter value of x");
            x = Byte.Parse(Console.ReadLine());
            Console.WriteLine("enter value of y");
            y = Byte.Parse(Console.ReadLine());
            byte ch;
            Console.WriteLine("enter choice");
            ch = Byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1: Add(); break;
                case 2: Subtract(); break;
                case 3:
                    int product = Product();
                    Console.WriteLine($"Product is {product}"); break;
                case 4: Console.WriteLine($"Remiander is {Remainder()}"); break;
                default: Console.WriteLine("invalid choice"); break;
            }
        }

        static void Add()
        {
            Console.WriteLine($"Sum is {x + y}");
        }
        static void Subtract()

        {
            Console.WriteLine($"Difference is {x - y}");
        }
        static int Product()
        {
            return x * y;
        }
        static float Remainder()
        {
            return x % y;
        }
    }
}
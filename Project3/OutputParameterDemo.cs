using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class OutputParameterDemo
    {
        // how many values a function can return
        // only 1
        // if you want a function to return more than 1 values
        //,we can use output parameter

        static void Main()
        {
            int x = 20, y = 10;
            int add, difference, product;
            float rem;
            // calling part
            Operations(x, y, out add, out difference, out product, out rem);
            Console.WriteLine($"Sum is {add} Differece is {difference} Product is {product} Remainder is {rem}");


        }
        static void Operations(int x, int y,
            out int sum,
            out int difference,
            out int product,
            out float remainder)

        {
            sum = x + y;
            difference = y - x;
            product = x * y;
            remainder = x % x;

        }
    }
}

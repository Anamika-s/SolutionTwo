using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class MethodOverloading
    {
        static void Main()
        {
            Add(10, 20, 30);

        }

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Add(string x, string y, string z)
        {
            Console.WriteLine(string.Concat(x , " "  , y , " " , z));
        }

        static void Add(int x, float y)

        {
            Console.WriteLine(x+y);
        }
        static void Add(float x, int y)

        {
            Console.WriteLine(x + y);
        }
    }
}

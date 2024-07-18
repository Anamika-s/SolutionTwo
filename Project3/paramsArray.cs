using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class paramsArray
    {
        static void Main()
        {
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13));
            Console.WriteLine(Sum(2,3));
            Console.WriteLine(Sum(1,2,3,4,5));
        }
        static int  Sum(params int[] num)

        {
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;

        }
    }
}

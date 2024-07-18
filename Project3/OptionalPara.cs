using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class OptionalPara
    {
        static void Main()
        {
            SI(12000, 9);
            SI(15000, 8, 7);
            SI(20000);
        }
        // def / optional para means that while defining a method,
        // we want to give some def value to the patameters
        static void SI(int principle=20000, int rate=5 , int time=10)
        {
            Console.WriteLine((principle*rate*time)/100);
        }
    }
}

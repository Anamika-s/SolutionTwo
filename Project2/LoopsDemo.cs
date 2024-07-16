using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class LoopsDemo
    {
        static void Main()
        {
            // print from 1 to 10
            // do - while
            // every loop contains 3 statements
            // 1. initilaize
            // 2. condition
            // 3. inc / dec
            Console.WriteLine("do while loop");
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            }while(x <= 10);


            Console.WriteLine("using while loop");
            x = 1;
            while(x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.WriteLine("using for loop");
            for(x = 1;x <= 10;x++)
                Console.WriteLine(x);
        }
    }
}

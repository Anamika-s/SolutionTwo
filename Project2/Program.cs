namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            // how to take input from user
            Console.WriteLine("enter value of x");
            // scanf() cin>>
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter value of y");
            y = Convert.ToByte(Console.ReadLine());
            // 0 - 255

            //16 means 16 bits, 2 Bytes
            // 32 bits 4 bytes
            // UInt16 unsigned 16 bits
            // short long
            int ch;
            Console.WriteLine("enter ch");
            ch = Convert.ToByte(Console.ReadLine());
            if(ch==1)
                Console.WriteLine($"Sum of {x} and {y} is {x+y}");
            else if(ch==2)
                Console.WriteLine($"Difference of {x} and {y} is {x - y}");
            else if(ch==3)
                Console.WriteLine($"Product of {x} and {y} is {x * y}");
            else if(ch==4)
                Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
           else
                Console.WriteLine("invalid choice");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class GenericCollectionsDemo
    {
        static void Main()
        {
            // ArrayList  > List<T>
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            foreach(int i in list)
                Console.WriteLine(i);

            Stack<float> stack = new Stack<float>();
            stack.Push(0.8f);

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("aaa");

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict[10] = "ajay";
            //dict["aaa"] = 10;

        }
    }
}

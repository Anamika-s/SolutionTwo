using System.Collections;
using System.Collections.Generic;

namespace Project3
{
    internal class Program
    {
        static ArrayList list = new ArrayList();

        static void Main(string[] args)
        {
            // colllection is also a structure when we need to store
            // multiple elements
            // collections are dynamic in nature
            // ArrayList , Stack, Queue, HashTable
            // int [] num = new int[10];
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.Add("ajay");
            list.Add(90.7f);

            list.Add(99); // boxing happens 
            // converting a variable from value to reference type

            Display();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            Display();
            list.Insert(1, 1000);
            Console.WriteLine("after insertion, arraylist");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            Display();

            list.RemoveAt(0);
            list.Remove(300);

            // LIFO
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("stack");
            foreach (var item in stack)
                Console.WriteLine(item);

            stack.Pop();

            // FIFO
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();


            //How searching can be performed?, Its sequential
            foreach (var item in queue)
            {
                if ((int)item == 100)
                {

                }
            }
            // to search elements dynmaically, use HashTable
            // it store values using<key,value> pair
            Hashtable ht = new Hashtable();
            ht[10] = "ajay";
            ht[11] = "deepak";
            ht["madhav"] = "new delhi";
            Console.WriteLine(ht[11]);

            if(ht.ContainsKey(10))
            {
                Console.WriteLine(ht[10]);
            }

            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"RollNo {item} has {ht[item]} name");
            }
        }
        static void Display()
        {
            foreach (var temp in list) // unboxing happens
            {
                Console.WriteLine(temp);
            }
        }
    }
}
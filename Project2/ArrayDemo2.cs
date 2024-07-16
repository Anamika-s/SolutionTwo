using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    // take sum and average of array elements
    internal class ArrayDemo2
    {
        static void Main()
        {
            //int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // int[] num = new int[] { 1, 2, 3, 4 };
            int[] num = [1, 2, 34, 55, 6]; // C# 7.0
            Console.WriteLine("elements are");
            int sum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum+= num[i];
            //    Console.WriteLine(num[i]);
            //}
            foreach (int i in num)
            {
                sum += i;
            }

            float avg = (float)sum/ num.Length;
            Console.WriteLine($"Sum is {sum} Avg is {avg}");
          
        }
    }
}
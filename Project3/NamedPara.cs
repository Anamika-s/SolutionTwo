using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class NamedPara
    {
        static void Main()
        {
            //DispalyDetails(10, "Ravi Kumar", 90);
            //int you want to change sequence of parameters
            // or want to make program developer friendly,
            // while passing para to methods, we name them
            // we get named parameter
            DispalyDetails(id: 90, managerName: "Ravi Kuamr",
                address: "delhi", salary: 9009f, name: "deepak", exp: 9);
        }







































        static void DispalyDetails(int id, 
            string name, string address,
            int exp,
            float salary,
            string managerName)
        {
            Console.WriteLine($"Id is {id}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Address is {address}");
            Console.WriteLine($"Manager name is {managerName}");
            Console.WriteLine($"Exp is {exp}");
            Console.WriteLine($"Salary is {salary}");
        }
    }
}

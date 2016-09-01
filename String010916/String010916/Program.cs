using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String010916
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your full name.");
            string name;
            name = Console.ReadLine();


            Console.WriteLine("Name length: " + name.Length);

            Console.WriteLine("Name length without spaces: " + name.Replace(" ", string.Empty).Length);

            Console.WriteLine("Your first name is " + name.Split(' ')[0] + " and consists of " + name.Split(' ')[0].Length + " characters");

            Console.WriteLine("Your last name is " + name.Split(' ')[1] + " and consists of " + name.Split(' ')[1].Length + " characters");

            Console.WriteLine(name.Split(' ')[1]+", "+ name.Split(' ')[0]);



        }
    }
}

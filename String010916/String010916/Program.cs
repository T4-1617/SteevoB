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

            Console.WriteLine(name.Split(' ')[1]+", "+ name.Split(' ')[0] + "\n");


            foreach (char letter in name.Split(' ')[0])
            {
                Console.WriteLine("---->" + letter);
            }

            foreach (char letter in name.Split(' ')[1])
            {
                Console.WriteLine("------>" + letter);
            }

            string nameLow = name.ToLower();
            char[] nameArray = nameLow.ToCharArray();
            Console.Write("Your name backwards is: ");

            //char[] reverse = nameLow.ToCharArray();
            //Array.Reverse(reverse);
            //new string(reverse);
            //Console.WriteLine(reverse);

            for (int i = (name.Length - 1); i >= 0; i--)
            {
                Console.Write(nameArray[i]);
            }

            Console.WriteLine(string.Empty);

            for (int i = 0; i < name.Length; i++)
            {
                if(i%2 == 1)
                {
                    Console.Write(name[i].ToString().ToLower());
                }
                else
                {
                    Console.Write(name[i].ToString().ToUpper());
                }

            }

            Console.WriteLine(string.Empty);

            for (int i = 0; i < name.Length; i++)
            {
                switch (nameArray[i])
                {
                    case 'e':
                        Console.Write('3');
                        break;
                    case 'a':
                        Console.Write('4');
                        break;
                    case 'i':
                        Console.Write('1');
                        break;
                    case 't':
                        Console.Write('7');
                        break;
                    case 'o':
                        Console.Write('0');
                        break;
                    default: Console.Write(nameArray[i]);
                        break;
                }
            }
            Console.WriteLine(string.Empty);
        }
    }
}

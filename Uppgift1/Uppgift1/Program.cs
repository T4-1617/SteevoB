using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, skriv ditt förnamn");

            string nameF = System.Console.ReadLine();

            Console.WriteLine("och nu skriv ditt efternamn");

            string nameE = Console.ReadLine();

            Console.WriteLine("Hej " + nameF + " " + nameE);

            Console.WriteLine("Tryck enter för att avsluta!");

            Console.ReadLine();
        }
    }
}

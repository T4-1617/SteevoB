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
           

            Console.WriteLine("\nHej, skriv ditt efternamn nedan!");

            string nameE = Console.ReadLine();

            Console.WriteLine("Hej " + nameE);

            Console.WriteLine("Tryck enter för att avsluta!");

            Console.ReadLine();
        }
    }
}

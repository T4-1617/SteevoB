using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift5CnslCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tal 1:");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv in tal 2:");
            double value2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Välj räknesätt: (+ - * /)");
            string raknesatt = Console.ReadLine();
            double answer;
            switch(raknesatt)
            {
                case "+":
                    answer = value1 + value2;
                    Console.WriteLine(answer);
                    break;

                case "-":
                    answer = value1 - value2;
                    Console.WriteLine(answer);
                    break;

                case "*":
                    answer = value1 * value2;
                    Console.WriteLine(answer);
                    break;

                case "/":
                    answer = value1 / value2;
                    Console.WriteLine(answer);
                    break;

            }
            Console.WriteLine("Tryck Enter för att avsluta.");
            Console.ReadLine();

        }
    }
}
